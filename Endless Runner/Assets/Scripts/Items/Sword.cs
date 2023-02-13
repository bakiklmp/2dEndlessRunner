using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Sword : MonoBehaviour
{
    [SerializeField] private AbilityCheck abilityCheck;
    [SerializeField] private PlayerVariables playerVariables;
    private Animator animator;

    private float timeBtwAttack = 0;
    //[SerializeField] private Transform attackPosition;
    public LayerMask whatIsEnemy;

    public Controls controls;
    private InputAction attack;
    private void Awake()
    {
        controls = new Controls();
    }
    private void OnEnable()
    {
        attack = controls.Main.Attack;
        attack.Enable();
        attack.performed += _ => Attack();
    }
    private void OnDisable()
    {
        attack.Disable();
    }
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Attack()
    {
        if (abilityCheck.attack)
        {
            if (timeBtwAttack <= 0)
            {
                Debug.Log("BAAAAAAS");
                animator.SetTrigger("Attack");
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(transform.position, playerVariables.attackRange, whatIsEnemy);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<YellowBox>().TakeDamage(playerVariables.attackDamage);
                }
                timeBtwAttack = playerVariables.attackSpeed;
                StartCoroutine(AttackCooldown());
            }
        }
    }
    IEnumerator AttackCooldown()
    {
        while (timeBtwAttack > 0)
        {
            timeBtwAttack -= Time.deltaTime;
            yield return null;
        }
    }
    private void OnDrawGizmosSelected()
    {
        /*Vector2 boxCastOrigin = (Vector2)transform.position + Vector2.down * (boxSize.y / 2 + 0.1f);        
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(boxCastOrigin, boxSize);*/

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, playerVariables.attackRange);

    }
}
