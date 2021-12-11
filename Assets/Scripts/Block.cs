using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Transform block;
    public GameObject PaintColorPreFabRed1;
    public GameObject PaintColorPreFabBlue1;
    public GameObject PaintColorPreFabYellow1;

    public GameObject PaintColorPreFabRed2;
    public GameObject PaintColorPreFabBlue2;
    public GameObject PaintColorPreFabYellow2;

    public GameObject PaintColorPreFabRed3;
    public GameObject PaintColorPreFabBlue3;
    public GameObject PaintColorPreFabYellow3;

    public GameObject Red1;
    public GameObject Red2;
    public GameObject Red3;

    public GameObject Blue1;
    public GameObject Blue2;
    public GameObject Blue3;

    public GameObject Yellow1;
    public GameObject Yellow2;
    public GameObject Yellow3;

    public GameObject RedSymbol;
    public GameObject BlueSymbol;
    public GameObject YellowSymbol;

    public GameObject player;
    public ResetPaint rp;
    //Right now I need it so that Red, Blue, Yellow, and numPaint reset when the paint is gone
    public int Red = 0;
    public int Blue = 0;
    public int Yellow = 0;
    public int numPaint; //This counts the number of paint on this block

    public AudioSource myAudio;
    public AudioClip splotch;
    // Start is called before the first frame update
    void Start()
    {
        NoColor();
    }
    public void ChangeColor(string color)
    {
        myAudio.PlayOneShot(splotch, 1f);
        if (color == "blue" && numPaint < 3)
        {
            if (numPaint == 0)
            {
                var paint = Instantiate(PaintColorPreFabBlue1, new Vector3(block.position.x, block.position.y, 0), block.rotation); 
                numPaint++; 
                paint.transform.parent = gameObject.transform;
            }
            else if (numPaint == 1)
            {
                var paint = Instantiate(PaintColorPreFabBlue2, new Vector3(block.position.x, block.position.y, 0), block.rotation); 
                numPaint++; paint.transform.parent = gameObject.transform;
            }
            else if (numPaint == 2)
            {
                var paint = Instantiate(PaintColorPreFabBlue3, new Vector3(block.position.x, block.position.y, 0), block.rotation); 
                numPaint++; paint.transform.parent = gameObject.transform;
            }
            Blue++;
            if (Blue == 1)
            {
                Debug.Log("Blue Number 1");
                Blue1.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (Blue == 2)
            {
                Debug.Log("Blue Number 2");
                Blue1.transform.localScale = new Vector3(0, 0, 0);
                Blue2.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (Blue == 3)
            {
                Debug.Log("Blue Number 3");
                Blue2.transform.localScale = new Vector3(0, 0, 0);
                Blue3.transform.localScale = new Vector3(1, 1, 1);
            }
            if (Blue != 0)
            {
                BlueSymbol.transform.localScale = new Vector3(1, 1, 1);
            }

        }
        else if (color == "red" && numPaint < 3) 
        {
            if (numPaint == 0)
            {
                var paint = Instantiate(PaintColorPreFabRed1, new Vector3(block.position.x, block.position.y, 0), block.rotation); 
                numPaint++;
                paint.transform.parent = gameObject.transform;
            }
            else if (numPaint == 1)
            {
                var paint = Instantiate(PaintColorPreFabRed2, new Vector3(block.position.x, block.position.y, 0), block.rotation); 
                numPaint++;
                paint.transform.parent = gameObject.transform;
            }
            else if (numPaint == 2)
            {
                var paint = Instantiate(PaintColorPreFabRed3, new Vector3(block.position.x, block.position.y, 0), block.rotation); 
                numPaint++;
                paint.transform.parent = gameObject.transform;
            }
            Red++; 
            if (Red == 1)
            {
                Debug.Log("Red Number 1");
                Red1.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (Red == 2)
            {
                Debug.Log("Red Number 2");
                Red1.transform.localScale = new Vector3(0, 0, 0);
                Red2.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (Red == 3)
            {
                Debug.Log("Red Number 3");
                Red2.transform.localScale = new Vector3(0, 0, 0);
                Red3.transform.localScale = new Vector3(1, 1, 1);
            }
            if (Red != 0)
            {
                RedSymbol.transform.localScale = new Vector3(1, 1, 1);
            }
        }
        else if (color == "yellow" && numPaint < 3)
        {
            if (numPaint == 0)
            {
                var paint = Instantiate(PaintColorPreFabYellow1, new Vector3(block.position.x, block.position.y, 0), block.rotation); 
                numPaint++; paint.transform.parent = gameObject.transform;
            }
            else if (numPaint == 1)
            {
                var paint = Instantiate(PaintColorPreFabYellow2, new Vector3(block.position.x, block.position.y, 0), block.rotation); 
                numPaint++; paint.transform.parent = gameObject.transform;
            }
            else if (numPaint == 2)
            {
                var paint = Instantiate(PaintColorPreFabYellow3, new Vector3(block.position.x, block.position.y, 0), block.rotation); 
                numPaint++; paint.transform.parent = gameObject.transform;
            }
            Yellow++; 
            if (Yellow == 1)
            {
                Debug.Log("Yellow Number 1");
                Yellow1.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (Yellow == 2)
            {
                Debug.Log("Yellow Number 2");
                Yellow1.transform.localScale = new Vector3(0, 0, 0);
                Yellow2.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (Yellow == 3)
            {
                Debug.Log("Yellow Number 3");
                Yellow2.transform.localScale = new Vector3(0, 0, 0);
                Yellow3.transform.localScale = new Vector3(1, 1, 1);
            }
            if (Yellow != 0)
            {
                YellowSymbol.transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButtonDown("Reset") || player.transform.position.y < -30 || rp.clean == true) && (!PauseMenu.GameIsPaused && !PaintStand.MenuOpen))
        {
            numPaint = 0;
            Blue = 0;
            Red = 0;
            Yellow = 0;
            NoColor();
        }
    }
    public void NoColor()
    {
        Red1.transform.localScale = new Vector3(0, 0, 0);
        Red2.transform.localScale = new Vector3(0, 0, 0);
        Red3.transform.localScale = new Vector3(0, 0, 0);

        Blue1.transform.localScale = new Vector3(0, 0, 0);
        Blue2.transform.localScale = new Vector3(0, 0, 0);
        Blue3.transform.localScale = new Vector3(0, 0, 0);

        Yellow1.transform.localScale = new Vector3(0, 0, 0);
        Yellow2.transform.localScale = new Vector3(0, 0, 0);
        Yellow3.transform.localScale = new Vector3(0, 0, 0);

        RedSymbol.transform.localScale = new Vector3(0, 0, 0);
        BlueSymbol.transform.localScale = new Vector3(0, 0, 0);
        YellowSymbol.transform.localScale = new Vector3(0, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("Trigger! Something is still on me!");
        //These next few lines of code tells Arthur what color paint he is standing on.
        //Destroy(gameObject);
        if (collider.gameObject.tag == "Cleaner")
        {
            NoColor();
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        //Debug.Log("Trigger! Something is still on me!");
        //These next few lines of code tells Arthur what color paint he is standing on.
        //Destroy(gameObject);
        if (collider.gameObject.tag == "Cleaner")
        {
            NoColor();
        }
    }
}  