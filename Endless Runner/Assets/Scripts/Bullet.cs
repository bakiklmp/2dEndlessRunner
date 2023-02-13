using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D bulletRb;
    [SerializeField] float bulletSpeed;
    float startPosition;
    float currentPosition;
    private void Start()
    {
        bulletRb = GetComponent<Rigidbody2D>();
        startPosition = transform.position.x;
    }
    void Update()
    {
        bulletRb.velocity = new Vector2(bulletSpeed, 0);
        currentPosition = transform.position.x;
        if (Mathf.Abs(currentPosition - startPosition) >= 100f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("YellowBox"))
        {
            Destroy(gameObject);
        }
    }
}
