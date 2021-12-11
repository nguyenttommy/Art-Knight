using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAggro : MonoBehaviour
{

    public Transform player;

    public float agroRange;

    public Rigidbody2D rb;

    public MovementVar mv;
    private float speed;
    public Transform respawnPoint;
    public Animator animator;

    public LevelManager lm;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        transform.position = respawnPoint.transform.position;
        //rb = GetComponent<Rigidbody2D>();        
        speed = mv.MovementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.GameIsPaused && !PaintStand.MenuOpen)
        {
            //Distance to player
            float distToPlayer = Vector2.Distance(transform.position, player.position);
            //Debug.Log(distToPlayer);

            if (distToPlayer < agroRange)
            {
                //Code to chase the player
                ChasePlayer();
            }
            else
            {
                StopChasingPlayer();
                //Stop chasing player
            }//player.transform.position.y < -30
            if (Input.GetButtonDown("Reset"))
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
                transform.position = respawnPoint.transform.position; mv.MovementSpeed = speed;
            }
            if (lm.playDeath)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
                transform.position = respawnPoint.transform.position; mv.MovementSpeed = speed;
            }
            if (transform.position.y < -10)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
                transform.position = respawnPoint.transform.position; mv.MovementSpeed = speed;
            }
        }
    }
    void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            rb.velocity = new Vector2(mv.MovementSpeed, rb.velocity.y);
            //rb.velocity.x = moveSpeed;
            transform.localScale = new Vector2(1, 1);
        }
        else if (transform.position.x > player.position.x)
        {
            rb.velocity = new Vector2(-mv.MovementSpeed, rb.velocity.y);
            transform.localScale = new Vector2(-1, 1);
        }
        animator.SetBool("chase", true);
    }
    void StopChasingPlayer()
    {
        animator.SetBool("chase", false);
        rb.velocity = new Vector2(0, 0);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            transform.position = respawnPoint.transform.position; 
            mv.MovementSpeed = speed;
        }
    }
}
