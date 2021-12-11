using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script contains the parts that will hold the Movement speed, Jump force, and the ability to flip for a character.
public class MovementVar : MonoBehaviour
{
    public float MovementSpeed; 
    public float JumpForce;
    public bool facingRight = true; //This helps Arthur flip which way he is facing
    public float face;//This helps the dash figure which way Arthur is facing
                      // Start is called before the first frame update
    public float movement;
    public float dashDistance = 10f;
    public bool isDashing = false;
    public bool isJumping = false;
    public bool slow = false;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
