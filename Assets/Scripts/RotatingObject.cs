using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    float originalZ;

    public float floatStrength = 1; // You can change this in the Unity Editor to 
                                    // change the range of y positions that are possible.

    void Start()
    {
        this.originalZ = this.transform.position.z;
    }

    void Update()
    {
        transform.localRotation = Quaternion.Euler(0, 0, -135.86f + ((float)Mathf.Sin(Time.time*10) * floatStrength));
    }
}
//            this.transform.localRotation = Quaternion.Euler(0, 0, 30);