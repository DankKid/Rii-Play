using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    private Rigidbody2D bulletRigidbody;
    public float bulletSpeed = 10f;

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            ContactPoint2D contactPoint = collision.contacts[0];
            Vector2 bulletVelocity = bulletRigidbody.velocity;
            Vector2 reflectionVector = Vector2.Reflect(bulletVelocity.normalized, contactPoint.normal);
            //Debug.Log("Bullet velocity: " + bulletVelocity);
            //Debug.Log("Reflection vector: " + reflectionVector);
            bulletRigidbody.velocity = reflectionVector * bulletSpeed;
        }
    }
}
