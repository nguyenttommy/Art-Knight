using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplenishPaint : MonoBehaviour
{
    public PaintShot ps;

    public bool red = false;
    public bool blue = false;
    public bool yellow = false;

    public GameObject Blob;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        { 
            Debug.Log("Refill paint");
            if (red)
            {   Debug.Log("Refill paint RED");
                ps.ReplenishRed();
            }
            else if (blue)
            {
                Debug.Log("Refill paint BLUE");
                ps.ReplenishBlue();
            }
            else if(yellow)
            {
                Debug.Log("Refill paint YELLOW");
                ps.ReplenishYellow();
            }
            ps.TrackUpdate();
            Blob.SetActive(false);//This "destroys" this object
        }
    }
}