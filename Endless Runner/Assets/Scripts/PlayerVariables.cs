using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PlayerVariable",menuName ="ScriptableObject/Variables")]
public class PlayerVariables : ScriptableObject
{
    [Header("Movement")]
    public float moveSpeed;
    public float maxSpeed;
    [Header("Jumping")]
    public float jumpForce;
    public float smallJumpForce;
    public float doubleIndexJumpForce;
    public float coyoteTime;
    public float jumpBufferLength;
    public float fallingGravityMultiplier;
    [Header("Rolling")]
    public float rollDuration;
    [Header("Backdashing")]
    public float backdashSpeed;
    public float backdashDuration;    
    [Header("Attacking")]
    public float attackSpeed;
    public float attackRange;
    public int attackDamage;

}
