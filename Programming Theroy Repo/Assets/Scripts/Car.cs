using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    public float speed;
    
    private Rigidbody carRb;

    private void Start() {
        speed = 500f;
        carRb = GetComponent<Rigidbody>();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.T)){
            carRb.AddForce(Vector3.right * speed, ForceMode.VelocityChange);
        }
    }

}
