using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankController : MonoBehaviour
{
    // Tank movement variables
    public float moveSpeed = 5f;
    public float rotationSpeed = 180f;
    // Tank firing variables
    Vector3 mousePos = new Vector3();
    Vector3 moosePos = new Vector3();
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.5f;
    private float fireTimer = 0f;
    public float bulletSpeed = 1;
    public Transform bulletParent;

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
       
        var mousePos = Input.mousePosition;
        mousePos.z = 10;
        moosePos = Camera.main.ScreenToWorldPoint(mousePos);
        // Tank movement input
        float moveInput = Input.GetAxis("Vertical");
        float rotateInput = Input.GetAxis("Horizontal");

        // Tank movement
        rb.velocity = transform.up * moveInput * moveSpeed;
        rb.angularVelocity = -rotateInput * rotationSpeed;

        // Tank firing
       
        fireTimer += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && bulletParent.childCount<5) 
        {
            Fire();
            fireTimer = 0f;
        }
    }

    void Fire()
    {
        Vector2 direction = moosePos - firePoint.position;
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity, bulletParent) as GameObject;
        bullet.GetComponent<Rigidbody2D>().velocity =  direction.normalized * bulletSpeed;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        bullet.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward) * Quaternion.Euler(0, 0, -90);
    }
    // Start is called before the first frame update
}
