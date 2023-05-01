using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    public GameObject explosion;
    private Rigidbody2D bulletRigidbody;
    public float bulletSpeed = 10f;
    public float maxBounce = 1;
    public float currentBounce = 0;
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Wall")
        {
            currentBounce++;
            ContactPoint2D contactPoint = collision.contacts[0];
            Vector2 bulletVelocity = bulletRigidbody.velocity;
            Vector2 reflectionVector = Vector2.Reflect(bulletVelocity.normalized, contactPoint.normal);
            //Debug.Log("Bullet velocity: " + bulletVelocity);
            //Debug.Log("Reflection vector: " + reflectionVector);
            bulletRigidbody.velocity = reflectionVector * bulletSpeed;
            float angle = Mathf.Atan2(reflectionVector.y, reflectionVector.x) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward)*Quaternion.Euler(0,0,-90);
            if (currentBounce > maxBounce)
            {
                Instantiate(explosion, this.transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }
    }
}
