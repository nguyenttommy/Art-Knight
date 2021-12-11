using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCleaner : MonoBehaviour
{
    public Transform[] target;

    public float agroRange;

    public Rigidbody2D rb;

    public MovementVar mv;

    public Transform respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = respawnPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        gameObjectsRed = GameObject.FindGameObjectsWithTag("RED");
        gameObjectsBlue = GameObject.FindGameObjectsWithTag("BLUE");
        gameObjectsYellow = GameObject.FindGameObjectsWithTag("YELLOW");
        //Debug.Log(distToPlayer);
        */


        /*
        for (int i = 0; i < target.size; i++)
        {
            if (target[i] != null)
            {
                float distToPlayer = Vector2.Distance(target[i].position, transform.position);
                if (i > 0)
                {
                    float DistanceFromLastTarget = Vector2.Distance(target[i - 1].position, transform.position);
                }
                else
                {
                    float DistanceFromLastTarget = 0f;
                }
                if (DistanceFromTarget > DistanceFromLastTarget)
                {
                    int MainTarget = i;
                }
            }
        }
        */



    }
}
/*        float distToPlayer = Vector2.Distance(transform.position,player.position);
                if (distToPlayer<agroRange)
                {
                    //Code to chase the player
                    if (transform.position.x<target[i].position.x)
                    {
                        rb.velocity = new Vector2(mv.MovementSpeed, rb.velocity.y);
//rb.velocity.x = moveSpeed;
transform.localScale = new Vector2(1, 1);
                    }
                    else if (transform.position.x > target[i].position.x)
                    {
                        rb.velocity = new Vector2(-mv.MovementSpeed, rb.velocity.y);
transform.localScale = new Vector2(-1, 1);
                    }
                }
                else
                {
                    rb.velocity = new Vector2(0, 0);
                    //Stop chasing player
                }
*/
