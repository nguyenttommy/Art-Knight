using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanerPatrol : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool movingRight = true;//Where it should move
    public Transform groundDetection;
    public MovementVar mv;
    public GameObject gameObject;
    public Animator animator;
    private float speed;
    public Transform respawnPoint;
    public LevelManager lm;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = respawnPoint.transform.position;
        speed = mv.MovementSpeed; rb.velocity = new Vector2(rb.velocity.x, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.GameIsPaused && !PaintStand.MenuOpen)
        {
            if (movingRight == true)
                rb.velocity = new Vector2(mv.MovementSpeed, rb.velocity.y);
            else
            {
                rb.velocity = new Vector2(-mv.MovementSpeed, rb.velocity.y);
            }
            animator.SetBool("chase", true);

            RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);
            if (groundInfo.collider == false)
            {
                if (movingRight == true)
                {
                    movingRight = false;
                    transform.localScale = new Vector2(-1, 1);
                }
                else if (movingRight == false)
                {
                    movingRight = true;
                    transform.localScale = new Vector2(1, 1);
                }
            }
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
            if (transform.position.y < -30)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
                transform.position = respawnPoint.transform.position; mv.MovementSpeed = speed;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collider)
    {//Platform = Horizontal
        //PlatformVert = Vertical
        if (collider.gameObject.tag == "Platform" && Input.GetAxisRaw("Horizontal") == 0f)
        {
            transform.parent = collider.transform;
            Debug.Log("THIS IS A PLATFORM");
        }
        else if (collider.gameObject.tag == "Platform")
        {
            transform.parent = null;
            Debug.Log("IDLE");
        }
        if (collider.gameObject.tag == "PlatformVert" && Input.GetAxisRaw("Horizontal") == 0f)
        {
            transform.parent = collider.transform;
            Debug.Log("THIS IS A PLATFORM");
        }
        else if (collider.gameObject.tag == "PlatformVert")
        {
            transform.parent = null;
            Debug.Log("IDLE");
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Platform")
        {
            transform.parent = null;
        }
    }
}
