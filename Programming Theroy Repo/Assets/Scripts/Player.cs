using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    Rigidbody playerRb;
    [SerializeField] bool isGrounded;

    private void Start()
    {
        MaximumLife = 500;
        speed = 2f;
        rotationSpeed = 100f;
        jumpStrength = 150f;
        playerRb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    protected override void UseHability()
    {
        // Use Hability
    }

    private void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput, Space.Self);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontalInput, Space.Self);

        if(Input.GetKeyDown(KeyCode.Space)) {
            playerRb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    
    private void FixedUpdate() {
    
        transform.rotation = new Quaternion(0, transform.rotation.y, 0, transform.rotation.w);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.layer == 12) {
            
            isGrounded = true;
        }
    }
}
