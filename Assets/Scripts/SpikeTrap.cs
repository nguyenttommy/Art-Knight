using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    float originalY; 
    public float timeLeft; 
    public float OriginalTime = 120;

    public bool kill = true;
    public BoxCollider2D bc2d;
    public bool pop;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = OriginalTime;
        this.originalY = this.transform.position.y;
        pop = false;
        if (kill)
        {
            bc2d.enabled = true;
        }
        else
        {
            bc2d.enabled = false;
        }
    }

    void Update()
    {//On player death, reset timer
        if (kill)
        {
            //Debug.Log("True");
            bc2d.enabled = true;
        }
        else
        {
            //Debug.Log("False");
            bc2d.enabled = false;
        }
        if (!pop)
        {
            if (timeLeft > 0)
            {//Stays hidden for timeLeft seconds
                timeLeft -= Time.deltaTime;
            }
            else
            {//Pops out for timeLeft/2 seconds
                timeLeft = 0;
                //timerIsRunning = false;
                //Something happens when time is done   
                //Debug.Log("TEst");
                transform.position = new Vector3(transform.position.x, transform.position.y + .5f, transform.position.z);
                pop = true; 
                timeLeft = OriginalTime;
                if (kill)
                {
                    kill = false;
                }
                else
                {
                    kill = true;
                }
            }
        }
        else 
        {
            if (timeLeft > 0)
            {//Stays hidden for timeLeft seconds
                timeLeft -= Time.deltaTime;
            }
            else
            {//Pops out for timeLeft/2 seconds
                timeLeft = 0;
                //timerIsRunning = false;
                //Something happens when time is done        
                transform.position = new Vector3(transform.position.x, transform.position.y - .5f, transform.position.z);
                pop = false;
                timeLeft = OriginalTime; 
                if (kill)
                {
                    kill = false;
                }
                else
                {
                    kill = true;
                }
            }
        }
    }
}
