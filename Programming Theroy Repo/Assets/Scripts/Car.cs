using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    public GameObject[] wheels = new GameObject[4];

    private WheelCollider leftWheel;
    private WheelCollider rightWheel;

    private void Start()
    {
        leftWheel = wheels[0].GetComponent<WheelCollider>();
        rightWheel = wheels[1].GetComponent<WheelCollider>();

        leftWheel.motorTorque = .01f;
        rightWheel.motorTorque = .01f;
    }
}
