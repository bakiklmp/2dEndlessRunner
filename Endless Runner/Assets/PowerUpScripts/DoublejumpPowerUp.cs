using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublejumpPowerUp : MonoBehaviour
{
    [SerializeField] AbilityCheck abilityCheck;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            abilityCheck.doubleJump = true;
            Destroy(gameObject);
        }
    }
}
