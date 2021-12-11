using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorNumbers : MonoBehaviour
{//This script keeps a small visible number under a block

    public Block block;


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
    // Start is called before the first frame update
    void Start()
    {
        NoColor();
    }

    // Update is called once per frame
    void Update()
    {

        if (block.Red == 1)
        {
            Debug.Log("Red Number 1");
            Red1.transform.localScale = new Vector3(1,1,1);
        }
        else if(block.Red == 2)
        {
            Debug.Log("Red Number 2");
            Red1.transform.localScale = new Vector3(0, 0, 0); 
            Red2.transform.localScale = new Vector3(1, 1, 1); 
        }
        else if (block.Red == 3)
        {
            Debug.Log("Red Number 3");
            Red2.transform.localScale = new Vector3(0, 0, 0); 
            Red3.transform.localScale = new Vector3(1, 1, 1); 
        }

        if (block.Red != 0)
        {
            RedSymbol.transform.localScale = new Vector3(1, 1, 1); 
        }


        if (block.Blue == 1)
        {
            Debug.Log("Blue Number 1");
            Blue1.transform.localScale = new Vector3(1, 1, 1); 
        }
        else if (block.Blue == 2)
        {
            Debug.Log("Blue Number 2");
            Blue1.transform.localScale = new Vector3(0, 0, 0); 
            Blue2.transform.localScale = new Vector3(1, 1, 1); 
        }
        else if (block.Blue == 3)
        {
            Debug.Log("Blue Number 3");
            Blue2.transform.localScale = new Vector3(0, 0, 0); 
            Blue3.transform.localScale = new Vector3(1, 1, 1); 
        }
        if (block.Blue != 0)
        { 
            BlueSymbol.transform.localScale = new Vector3(1, 1, 1); 
        }

        if (block.Yellow == 1)
        {
            Debug.Log("Yellow Number 1");
            Yellow1.transform.localScale = new Vector3(1, 1, 1); 
        }
        else if (block.Yellow == 2)
        {
            Debug.Log("Yellow Number 2");
            Yellow1.transform.localScale = new Vector3(0, 0, 0); 
            Yellow2.transform.localScale = new Vector3(1, 1, 1); 
        }
        else if (block.Yellow == 3)
        {
            Debug.Log("Yellow Number 3");
            Yellow2.transform.localScale = new Vector3(0, 0, 0); 
            Yellow3.transform.localScale = new Vector3(1, 1, 1); 
        }
        if (block.Yellow != 0)
        { 
            YellowSymbol.transform.localScale = new Vector3(1, 1, 1); 
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
}






