using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            ContactPoint2D contactPoint = collision.contacts[0];
            Vector2 reflectDirection = Vector2.Reflect(rb.velocity.normalized, contactPoint.normal);
            rb.velocity = reflectDirection * rb.velocity.magnitude;
        }
    }

    private void FixedUpdate()
    {
        transform.position += (Vector3)rb.velocity * Time.fixedDeltaTime;
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg);
    }
}
