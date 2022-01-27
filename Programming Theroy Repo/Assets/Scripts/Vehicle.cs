using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{

    protected Player player;
    public Character driver;

    protected Rigidbody vehicleRb;
    protected Collider actionAreaCollider;

    protected void Start() {
        vehicleRb = GetComponent<Rigidbody>();
        print("Rigidbody capturado");
        actionAreaCollider = GetComponent<Collider>();
        actionAreaCollider.isTrigger = true;
        print("Collider de acción capturado");
    }

}
