using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintEffects : MonoBehaviour
{
    public float originalSpeed;
    // Start is called before the first frame update
    private MovementVar moveScript;
    private new Rigidbody2D rigidbody2D;
    public GameObject moveVar;
    public float gravity;

    bool canJump = true;
    float JumpVelo = 0;
    int redCount = 0;
    void Start()
    {
        //gravity = rigidbody2D.gravityScale;
        moveScript = moveVar.GetComponent<MovementVar>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        if (!moveScript.slow)
        { 
            originalSpeed = moveScript.MovementSpeed; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(moveScript.isDashing != true)
            rigidbody2D.gravityScale = gravity;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("Trigger! Something entered!");
        //These next few lines of code tells Arthur what color paint he is standing on.
        
        if (canJump && (collider.gameObject.tag == "RED" || collider.gameObject.tag == "RED PERM"))
        {
          if (redCount != 6)
            { 
                redCount++;
            }
            //Debug.Log("amount of paint" + redCount);
            canJump = false;
            //Debug.Log("On RED"); 
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 0);
            rigidbody2D.AddForce(new Vector2(0, moveScript.JumpForce), ForceMode2D.Impulse); 
            JumpVelo += moveScript.JumpForce;
        }


        //Red2
        else if (canJump && (collider.gameObject.tag == "Red2" || collider.gameObject.tag == "RED PERM"))
        {
            if (redCount != 6)
            {
                redCount++;
            }
            //Debug.Log("amount of paint" + redCount);
            canJump = false;
            //Debug.Log("On RED2");
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 0);
            rigidbody2D.AddForce(new Vector2(0, moveScript.JumpForce* 1.75f), ForceMode2D.Impulse);
            JumpVelo += moveScript.JumpForce;

        }


        //Red3
        else if (canJump && (collider.gameObject.tag == "Red3" || collider.gameObject.tag == "RED PERM"))
        {
            if (redCount != 6)
            {
                redCount++;
            }
            //Debug.Log("amount of paint" + redCount);
            canJump = false;
            //Debug.Log("On RED3");
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 0);
            rigidbody2D.AddForce(new Vector2(0, moveScript.JumpForce*2.5f), ForceMode2D.Impulse);
            JumpVelo += moveScript.JumpForce;
        }
        if ((collider.gameObject.tag == "BLUE" || collider.gameObject.tag == "BLUE PERM") )//&& moveScript.isDashing == false)
        {
            StartCoroutine(Dashing(moveScript.face));
            //Debug.Log("USING BLUE");
        }

        canJump = true;
    }
    private void OnTriggerStay2D(Collider2D collider)
    {

        //Debug.Log("Trigger! Something is still on me!");
        //These next few lines of code tells Arthur what color paint he is standing on.
        if (canJump && (collider.gameObject.tag == "RED" || collider.gameObject.tag == "RED PERM"))
        {
            canJump = false;
            //Debug.Log("On RED");
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 0);
            rigidbody2D.AddForce(new Vector2(0, moveScript.JumpForce* (redCount / 2)), ForceMode2D.Impulse);
            //Debug.Log("This is happeneing");
        }
        else if ((collider.gameObject.tag == "YELLOW" || collider.gameObject.tag == "YELLOW PERM") && this.gameObject.tag != "Player")
        {
            moveScript.slow = true;
            moveScript.MovementSpeed = 2f;
        }
        canJump = true;
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if ((collider.gameObject.tag == "YELLOW" || collider.gameObject.tag == "YELLOW PERM"))
        {
            moveScript.slow = false;
            moveScript.MovementSpeed = originalSpeed;
        }
        redCount = 0;
        //JumpVelo = 0;

        //Debug.Log("Exited");
    }
    IEnumerator Dashing(float direction)
    {
        moveScript.isDashing = true;
        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x*1.35f, 0);
        rigidbody2D.AddForce(new Vector2(moveScript.dashDistance * direction, 0f), ForceMode2D.Impulse);
        rigidbody2D.gravityScale = 0;
        yield return new WaitForSeconds(0.2f);
        moveScript.isDashing = false;

    }
}
