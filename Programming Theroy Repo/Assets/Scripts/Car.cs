using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    public float speed;
    
    private new void Start() {
        speed = 500f;
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.T)){
            vehicleRb.AddForce(Vector3.right * speed, ForceMode.VelocityChange);
        }
    }

}
