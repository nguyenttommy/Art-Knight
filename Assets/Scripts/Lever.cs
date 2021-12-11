using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public bool lever = false;
    public Transform player;

    public float dist = 5f;
    public LevelManager lm;
    public bool upsideDown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//(90.0f, 0.0f, 0.0f, Space.Self);
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        if (lever)
        {
            if (upsideDown)
                this.transform.localRotation = Quaternion.Euler(180f, 0, 30);
            else
                    { 
                        this.transform.localRotation = Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, 30); 
                    }
        }
        else
        {
            if (upsideDown)
                this.transform.localRotation = Quaternion.Euler(180f, 0, -30);
            else
            {
                this.transform.localRotation = Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, -30);
            }
        }
        if (distToPlayer < dist)
        {
            if (Input.GetButtonDown("Interact"))
            {
                if (lever)
                {
                    lever = false;
                }
                else
                {
                    lever = true;
                }
            }
        }
        if (lm.playDeath)
        {
            Debug.Log("On player death, I'll create a rock");
            lever = false;
        }
    }
}
