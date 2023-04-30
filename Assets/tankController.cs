using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankController : MonoBehaviour
{
    // Tank movement variables
    public float moveSpeed = 5f;
    public float rotationSpeed = 180f;
    Vector3 point = new Vector3();
    // Tank firing variables
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.5f;
    private float fireTimer = 0f;
    public float bulletSpeed = 1;

    // Rigidbody2D component reference
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Get Rigidbody2D component reference
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(point);
        // Tank movement input
        float moveInput = Input.GetAxis("Vertical");
        float rotateInput = Input.GetAxis("Horizontal");

        // Tank movement
        rb.velocity = transform.up * moveInput * moveSpeed;
        rb.angularVelocity = -rotateInput * rotationSpeed;

        // Tank firing
        fireTimer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && fireTimer >= fireRate)
        {
            Fire();
            fireTimer = 0f;
        }
    }

    void Fire()
    {

        // Calculate the direction vector between the firePoint position and the mouse position
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - firePoint.position;

        // Instantiate a bullet and set its position and rotation
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bullet.transform.up = direction.normalized;

        // Apply a force to the bullet rigidbody in the calculated direction
        bullet.GetComponent<Rigidbody2D>().AddForce(direction.normalized * bulletSpeed, ForceMode2D.Impulse);
    }
    // Start is called before the first frame update
}
