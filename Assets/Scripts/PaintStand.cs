using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintStand : MonoBehaviour
{
    /*
     * This code should allow the player to walk up to a paint stand and press a button to pause the game and open the paint stand menu
     * This script should be attatched to the paint stand game object
     */
    public PauseMenu pm;

    public Transform player;

    public GameObject Stand;

    public bool close;

    public float dist = 5f;
    public static bool MenuOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        if (distToPlayer < dist)
        {
            close = true;
            //Show prompt to push certain button to open menu
            if (Input.GetButtonDown("Interact"))//This is the E key
            {
                if (MenuOpen)
                {
                    Time.timeScale = 1f;
                    Stand.SetActive(false);
                    MenuOpen = false;
                }
                else
                {
                    Time.timeScale = 0f;
                    Stand.SetActive(true);
                    MenuOpen = true;
                }
            }
            if (Input.GetButtonDown("Pause"))
            {
                if (MenuOpen)
                {
                    Time.timeScale = 1f;
                    Stand.SetActive(false);
                    MenuOpen = false;
                }
            }
        }
        else 
        {
            close = false;
        }
    }
}
