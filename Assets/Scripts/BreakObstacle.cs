using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakObstacle : MonoBehaviour
{
    public GameObject player; 
    public MovementVar moveScript;
    public GameObject Rock;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    { //if player is dashing or jumping, destroy object

        if (moveScript.isDashing)
        {
            Rock.SetActive(false);
            Debug.Log("Collide");

        }

    }
}
