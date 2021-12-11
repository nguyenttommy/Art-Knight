using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    float originalY;

    public float width = 1; // You can change this in the Unity Editor to 
                            // change the range of y positions that are possible.
    public float speed = 2f;
    public float fakeTime = 0;
    void Start()
    {
        this.originalY = this.transform.position.y;
    }

    void Update()
    {
        fakeTime += 0.004f;
        transform.position = new Vector3(transform.position.x, originalY + ((float)Mathf.Sin(fakeTime* speed) * width),
            transform.position.z);
    }
}
