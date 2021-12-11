using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingHorizontalObject : MonoBehaviour
{
    float originalX;

    public float width = 1; // You can change this in the Unity Editor to 
                                    // change the range of y positions that are possible.

    public float speed = 2f;
    public float fakeTime = 0;
    void Start()
    {
        this.originalX = this.transform.position.x;
    }

    void Update()
    {
        fakeTime += 0.004f;
        transform.position = new Vector3(originalX + ((float)Mathf.Sin(fakeTime * speed) * width), transform.position.y,
            transform.position.z);
    }


}
