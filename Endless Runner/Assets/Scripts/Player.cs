using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerVariables playerVariables;
    [SerializeField] private AbilityCheck abilityCheck;

     /*bool normalMovement;
     float moveSpeed = 5f;
     float maxSpeed = 15f;*/

    /*[Header("Rolling")]
    [SerializeField] float rollDuration;*/
    private bool isRolling = false;

    /*[Header("BackDash")]
    [SerializeField] private float backdashSpeed;
    [SerializeField] private float dashDuration;*/
    private float dashTime;
    private bool isDashing = false;

    /*[Header("Jump")]    
    public float jumpForce;
    public float doubleJumpForce;
    public bool doubleJumpAbility;
    public float coyoteTime;
    public float jumpBufferLength;
    public float smallJumpForce;
    public float gravityMultiplier;*/

    private bool isRunnerJumping;
    [SerializeField] private float runnerJumpingDuration;
    private float runnerJumpingTime;
   
    private float coyoteCounter;
    private float jumpBufferCounter;
    private bool canDoubleJump;

    public LayerMask whatIsGround;

    /*[Header("Attack")]
    [SerializeField] private float startTimeBtwAttack;
    [SerializeField] private float attackRange;
    [SerializeField] private int attackDamage;*/
    private float timeBtwAttack=0;    
    public Transform attackPosition;
    public LayerMask whatIsEnemy;
    

    Rigidbody2D playerRB;
    CapsuleCollider2D playerCollider;
    Animator animator;
    //Transform transform;
    SpriteRenderer spriteRenderer;
    public GameObject sword;
    public GameObject bullet;
    public Transform gunPosition;
    private Animator sword_animator;
    public Transform PivotPoint;

    float halfObjectSize;
    [SerializeField ]Vector2 boxSize;

    public Controls controls;
    private InputAction jump;
    private InputAction backdash;
    private InputAction move;
    private InputAction slide;
    private InputAction roll;
    private InputAction attack;
    private InputAction shoot;
    private InputAction runnerJump;


    Vector2 dir;
    private void Awake()
    {
        controls = new Controls();
    }
    private void OnEnable()
    {
        move = controls.Main.Move;
        move.Enable();

        slide = controls.Main.Slide;
        slide.Enable();
        //slide.performed += Shrink;
      //  slide.canceled += Shrink;

        runnerJump = controls.Main.RunnerJump;
        runnerJump.Enable();
        runnerJump.performed +=_ => RunnerJump();

        roll = controls.Main.Roll;
        roll.Enable();
       // roll.performed += _ => Roll();

        shoot = controls.Main.Shoot;
        shoot.Enable();
        shoot.performed += _ => Shoot();

        jump = controls.Main.Jump;
        jump.Enable();
        jump.performed += Jump;
        jump.canceled += Jump;

        attack = controls.Main.Attack;
        attack.Enable();
        //attack.performed += _ => Attack();

        backdash = controls.Main.Backdash;
        backdash.Enable();
        backdash.performed += _ => BackDash();

        
    }
    private void OnDisable()
    {
        move.Disable();
        jump.Disable();
        slide.Disable();
        roll.Disable();
        attack.Disable();
        backdash.Disable();
        shoot.Disable();
    }
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<CapsuleCollider2D>();
        animator = GetComponent<Animator>();
        //transform = GetComponent<Transform>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        halfObjectSize = transform.localScale.y * 0.5f;
        //Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, whatIsEnemy);

        sword_animator = sword.GetComponent<Animator>();
    }
    private void Update()
    {

        RunCheck();
        JumpCheck();
        //RollCheck();

    }
    void FixedUpdate()
    {
        if (isDashing)
        {            
            return;
        }
        if (abilityCheck.normalMovement)
        {
            dir = move.ReadValue<Vector2>();
            playerRB.velocity = new Vector2(dir.x * playerVariables.moveSpeed, playerRB.velocity.y);
        }
        //coyote time
        if (IsGrounded())
        {
            coyoteCounter = playerVariables.coyoteTime;
        }
        else
        {
            coyoteCounter -= Time.deltaTime;
        }
        //hýzlý düþme
        if (playerRB.velocity.y < 0)
        {
            playerRB.velocity += Vector2.up * Physics2D.gravity.y * (playerVariables.fallingGravityMultiplier - 1) * Time.deltaTime;
        }
        //double jump boolean
        if (IsGrounded())
        {
            //animator.SetBool("isJumping", false);
           // animator.SetBool("isDoubleJumping", false);
            canDoubleJump = true;
        }
        if(abilityCheck.forwardMovement)
        MovingForce();
    }
   /* void RollCheck()
    {
        if (isRolling)
        {
            animator.SetBool("Rolling", true);
        }
        else if (!isRolling)
        {
            animator.SetBool("Rolling", false);
        }
    }*/
    void JumpCheck()
    {
        if (playerRB.velocity.y > 0f)
        {
            animator.SetInteger("yVelocity",1);
        }
        else if (playerRB.velocity.y < 0f)
        {
            animator.SetInteger("yVelocity", -1);
        }
        else
        {
            animator.SetInteger("yVelocity", 0);
        }
    }
    void RunCheck()
    {
        if (playerRB.velocity.x < playerVariables.maxSpeed / 2)
        {
            animator.SetInteger("RunCheck", 0);
        }
        else if (playerRB.velocity.x > playerVariables.maxSpeed / 2 && playerRB.velocity.x < playerVariables.maxSpeed)
        {
            animator.SetInteger("RunCheck", 1);            
        }
        else if (playerRB.velocity.x >= playerVariables.maxSpeed)
        {
            animator.SetInteger("RunCheck", 2);
        }
        
    }
    void MovingForce()
    {
        playerRB.AddForce(Vector2.right * playerVariables.moveSpeed);
        if(playerRB.velocity.x >= playerVariables.maxSpeed)
        {
            playerRB.velocity = new Vector2(playerVariables.maxSpeed, playerRB.velocity.y);
        }
    }
    bool IsGrounded()
    {
        Vector2 boxOrigin = (Vector2)transform.position + Vector2.down * (boxSize.y / 2 + 0.1f);
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxOrigin, boxSize, 0f, Vector2.down, 0f, whatIsGround);
        return raycastHit2d.collider != null;
    }

    void Shoot()
    {
        if(abilityCheck.shoot)
        Instantiate(bullet,gunPosition.position,Quaternion.identity);
    }
   /* void Attack()
    {
        if (abilityCheck.attack)
        {
            if (timeBtwAttack <= 0)
            {
                Debug.Log("BAAAAAAS");
                sword_animator.SetTrigger("Attack");
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPosition.position, playerVariables.attackRange, whatIsEnemy);
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
   /* void Whip()
    {
        if (abilityCheck.whip)
        {
            if (timeBtwAttackWhip <= 0)
            {
                whip_animator.SetTrigger("Attack");
                Collider2D[] enemiesToDamage = Physics2D.OverlapBoxAll(attackPosition.position, playerVariables.attackRange, whatIsEnemy);

            }
        }
    }*/
    private void OnDrawGizmosSelected()
    {
        /*Vector2 boxCastOrigin = (Vector2)transform.position + Vector2.down * (boxSize.y / 2 + 0.1f);        
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(boxCastOrigin, boxSize);*/

      //  Gizmos.color = Color.red;
       // Gizmos.DrawWireSphere(attackPosition.position, playerVariables.attackRange);
        
    } 
    
    //input sisteminden gelen zýplama eylemi
    public void Jump(InputAction.CallbackContext context)//CONTEXTI JUMP YAP
    {

        if (context.performed)
        {            
            jumpBufferCounter =playerVariables.jumpBufferLength;            
        }
        else
        {
            jumpBufferCounter -= Time.deltaTime;
        }
        //zýplama ve sonsuz zýplamayý önleme
        if (jumpBufferCounter >= 0 && coyoteCounter > 0f)
        {
            Debug.Log("büyük");
            playerRB.velocity = new Vector2(playerRB.velocity.x, playerVariables.jumpForce);
            coyoteCounter = 0;
            jumpBufferCounter = 0;
        }
        else if (context.performed)
        {
            doubleJump();
        }

        //tuþtan elini çekince az zýplama
       /* if (context.canceled && playerRB.velocity.y > 0)
        {
            Debug.Log("küçük");
            playerRB.velocity = new Vector2(playerRB.velocity.x,playerRB.velocity.y * playerVariables.smallJumpForce);
            
            RunnerJump();
        }
       /* else if (context.canceled)
        {
            doubleJump();           
        }*/
    }

    void RunnerJump()
    {
        StartCoroutine(RunnerJumping());
    }
    IEnumerator RunnerJumping()
    {
        //isRunnerJumping = true;
        PivotPoint.localScale = new Vector3(PivotPoint.localScale.x, PivotPoint.localScale.y / 2, PivotPoint.localScale.z);
        playerRB.isKinematic = true;
        runnerJumpingTime = runnerJumpingDuration;
        while (runnerJumpingTime > 0)
        {
            runnerJumpingTime -= Time.deltaTime;
            yield return null;
        }
        PivotPoint.localScale = new Vector3(PivotPoint.localScale.x, PivotPoint.localScale.y * 2, PivotPoint.localScale.z);
        playerRB.isKinematic = false;
    }
   /* public void Shrink(InputAction.CallbackContext context)
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
        if(abilityCheck.roll)
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
    }*/

    public void doubleJump()
    {
        if (abilityCheck.doubleJump)
        {
            if (canDoubleJump)
            {               
                Debug.Log("duble");
                playerRB.velocity = new Vector2(playerRB.velocity.x, playerVariables.jumpForce * playerVariables.doubleIndexJumpForce);
                canDoubleJump = false;
               // animator.SetBool("isJumping", false);
               // animator.SetBool("isDoubleJumping", true);
            }
        }
    }
    void BackDash()
    {       
        if(abilityCheck.backdash)
        StartCoroutine(Backdashing());               
    }
    IEnumerator Backdashing()
    {
        isDashing = true;
        animator.SetBool("Backdashing", true);
        dashTime = playerVariables.backdashDuration;
        while (dashTime > 0)
        {
            dashTime -= Time.deltaTime;
            playerRB.velocity = new Vector2(-1 * playerVariables.backdashSpeed, playerRB.velocity.y);
          //  animator.SetBool("isBackDashing", true);
            yield return null;
                playerRB.velocity = new Vector2(playerVariables.maxSpeed / 2, playerRB.velocity.y);
        }        
        isDashing = false;
        animator.SetBool("Backdashing", false);
        // animator.SetBool("isBackDashing", false);
    }
    
}
