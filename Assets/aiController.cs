using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform target;
    public float bulletSpeed = 5f;
    public float moveSpeed = 5f;
    public float turnSpeed = 5f;
    public float fireRate = 1f;
    public Rigidbody2D rb;
    private bool canMove = true;
    private Transform playerTransform;
    private float nextFireTime;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        StartCoroutine(MoveAndStop());
    }

    private void Update()
    {
        //Calculate direction to player
        Vector2 direction = playerTransform.position - transform.position;
        direction.Normalize();
        // Fire bullet at player if enough time has passed
        if (Time.time > nextFireTime)
        {
            nextFireTime = Time.time + 1 / fireRate;
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            bulletRigidbody.velocity = direction * bulletSpeed;
        }
    }
    IEnumerator MoveAndStop()
    {
        while (true)
        {
            // Move for 2 seconds
            Move();

            yield return new WaitForSeconds(3f);

            // Stop for 1 second
            Stop();

            yield return new WaitForSeconds(2f);
        }
    }

    void Move()
    {

        canMove = true;

        // Move forward
        rb.velocity = transform.right * moveSpeed;

        // Rotate towards player
        Vector3 direction = target.position - transform.position;
        float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.AngleAxis(targetAngle, Vector3.forward);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    
}

    void Stop()
    {
        canMove = false;

        // Stop moving
        rb.velocity = Vector2.zero;
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            // Move forward
            rb.velocity = transform.right * moveSpeed;
        }
    }
}