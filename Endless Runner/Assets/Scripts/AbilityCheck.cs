using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PlayerAbilities",menuName ="ScriptableObject/Ability")]
public class AbilityCheck : ScriptableObject
{
    public bool normalMovement;
    public bool forwardMovement;
    public bool doubleJump;
    public bool backdash;
    public bool shoot;
    public bool attack;
    public bool shrink;
    public bool roll;

}
