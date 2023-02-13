using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkPowerUp : MonoBehaviour
{
    [SerializeField] AbilityCheck abilityCheck;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            abilityCheck.shrink = true;
            Destroy(gameObject);
        }
    }
}
