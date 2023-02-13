using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shrink_Roll : MonoBehaviour
{
    [SerializeField] private AbilityCheck abilityCheck;
    [SerializeField] private PlayerVariables playerVariables;

    private bool isRolling= false;
    private CapsuleCollider2D playerCollider;
    private SpriteRenderer spriteRenderer;
    public Controls controls;
    private InputAction roll;
    private InputAction shrink;
    float halfObjectSize;
    private Animator animator;

    private void Awake()
    {
        controls = new Controls();
    }
    private void OnEnable()
    {
        roll = controls.Main.Roll;
        roll.Enable();
        roll.performed += _ => Roll();

        shrink = controls.Main.Slide;
        shrink.Enable();
        shrink.performed += Shrink;
        shrink.canceled += Shrink;
    }
    private void OnDisable()
    {
        roll.Disable();
        shrink.Disable();
    }

    private void Start()
    {
        playerCollider = GetComponent<CapsuleCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        halfObjectSize = transform.localScale.y * 0.5f;
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (isRolling)
        {
            animator.SetBool("Rolling", true);
        }
        else if (!isRolling)
        {
            animator.SetBool("Rolling", false);
        }
    }

    public void Shrink(InputAction.CallbackContext context)
    {
        if (abilityCheck.shrink)
        {
            if (context.performed)
            {
                transform.localScale = new Vector3(transform.localScale.x, halfObjectSize, transform.localScale.z);
                playerCollider.size = playerCollider.size / 2;
            }
            else if (context.canceled)
            {
                transform.localScale = new Vector3(transform.localScale.x, halfObjectSize * 2, transform.localScale.z);
                playerCollider.size = playerCollider.size * 2;
            }
        }
    }
    void Roll()
    {
        if (abilityCheck.roll)
            StartCoroutine(Rolling());
    }
    IEnumerator Rolling()
    {
        isRolling = true;
        spriteRenderer.transform.rotation = Quaternion.Euler(0, 0, 360);
        playerCollider.size = playerCollider.size / 2;
        float rollingTime = playerVariables.rollDuration;
        while (rollingTime > 0)
        {
            rollingTime -= Time.deltaTime;
            transform.localScale = new Vector3(transform.localScale.x, halfObjectSize, transform.localScale.z);

            yield return null;
        }
        isRolling = false;
        transform.localScale = new Vector3(transform.localScale.x, halfObjectSize * 2, transform.localScale.z);
        playerCollider.size = playerCollider.size * 2;
    }
}
