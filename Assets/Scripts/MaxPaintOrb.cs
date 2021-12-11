using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxPaintOrb : MonoBehaviour
{
    public PaintShot ps;

    public bool red = false;
    public bool blue = false;
    public bool yellow = false;
    public bool isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isColliding = false;
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (isColliding)
            return;
        isColliding = true;

        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("Player Detected");
            if (red)
            {
                Debug.Log("Refill paint RED");
                ps.PlusOneRed();
            }
            else if (blue)
            {
                Debug.Log("Refill paint BLUE");
                ps.PlusOneBlue();
            }
            else if (yellow)
            {
                Debug.Log("Refill paint YELLOW");
                ps.PlusOneYellow();
            }
            Destroy(gameObject);
            //Blob.SetActive(false);//This "destroys" this object
        }
    }
}
