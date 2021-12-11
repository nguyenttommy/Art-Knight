using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This will hold the player controlled movements.
//This includes left to right movement, test jumping, and throwing/placing paint
public class PlayerControlMove : MonoBehaviour
{
    // Start is called before the first frame update
    public MovementVar moveScript;
    public GameObject moveVar;

    bool platformSpeed = false;

    public Animator animator;

    float maxVelocity = 200;

    public PauseMenu pm;
    public float movement;
    private new Rigidbody2D rigidbody2D;
    void Start()
    {
        moveScript = moveVar.GetComponent<MovementVar>();

        rigidbody2D = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity,maxVelocity);
        if (!PauseMenu.GameIsPaused && !PaintStand.MenuOpen)
        { 

            if (!moveScript.isDashing) 
        { 
            if (platformSpeed != true)
            movement = Input.GetAxisRaw("Horizontal");
            rigidbody2D.velocity = new Vector2(movement * moveScript.MovementSpeed, rigidbody2D.velocity.y);
            animator.SetFloat("Speed", Mathf.Abs(movement*moveScript.MovementSpeed));
        }




        /*if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody2D.velocity.y) < 0.001f)
        {
            rigidbody2D.AddForce(new Vector2(0, moveScript.JumpForce), ForceMode2D.Impulse);
        }*/

        if (moveScript.facingRight == false && movement > 0)
        {
            Flip();
            moveScript.face = 1;//This is here to fix dashing
        }
        else if (moveScript.facingRight == true && movement < 0)
        {
            Flip();
            moveScript.face = -1;//This is here to fix dashing
        }

        }
        void Flip()
        {
            moveScript.facingRight = !moveScript.facingRight;
            /*Vector3 Scaler = transform.localScale;
            Scaler.x *= -1;
            transform.localScale = Scaler;
            */
            transform.Rotate(0f, 180f, 0f);
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
    public void reset()
    {
        transform.parent = null;
        Debug.Log("Arthur is now orphaned");
    }
}
