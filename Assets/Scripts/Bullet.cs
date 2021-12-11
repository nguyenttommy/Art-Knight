using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody2D rb;

    public Sprite Red;
    public Sprite Yellow;
    public Sprite Blue;
    private string color;
    //I want to reference the paint swap script to detect the player changing the color of the current paint.

    public PaintSwap ps;

    public SpriteRenderer spriteRenderer;
    public ResetPaint reset;
    public PaintShot paintS;


    // Start is called before the first frame update
    void Start()
    {
        ps = FindObjectOfType<PaintSwap>();
        rb.velocity = transform.right * speed/2;
        if (ps.RedPaint == true)
        {
            spriteRenderer.sprite = Red;
            this.gameObject.tag = "RedBlob";
        }
        else if (ps.BluePaint == true)
        {
            spriteRenderer.sprite = Blue;
        }
        else if (ps.YellowPaint == true)
        {
            spriteRenderer.sprite = Yellow;
        }
    }
    void Update()
    {
        if (gameObject.transform.position.y < -30)
        { 
            Destroy(gameObject); 
            reset.ClearBlob();
        }
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Debug.Log(hitInfo.name);

        if (ps.RedPaint == true)
        {
            spriteRenderer.sprite = Red;
            color = "red"; 
        }
        else if (ps.BluePaint == Blue)
        {
            spriteRenderer.sprite = Blue;
            color = "blue";
        }
        else if (ps.YellowPaint == Yellow)
        {
            spriteRenderer.sprite = Yellow;
            color = "yellow";
        }
        Block block = hitInfo.GetComponent<Block>();
        if (hitInfo.gameObject.tag == "RED")
        {
            Debug.Log("THIS BULLET HIT RED");
        }
        if (block != null)
        {
            Debug.Log("Hit the block");
            block.ChangeColor(color);
        }
        //if(hitInfo.tag != "BLUE" && hitInfo.tag != "RED" && hitInfo.tag != "YELLOW")
        if (hitInfo.gameObject.tag != "Platform" && hitInfo.gameObject.tag != "PlatformVert" && hitInfo.gameObject.tag != "ResetTool" 
            && hitInfo.gameObject.tag != "Checkpoint" && hitInfo.gameObject.tag != "Go Through" && hitInfo.gameObject.tag != "Cleaner")
        Destroy(gameObject);
    }
    // Update is called once per frame
}
