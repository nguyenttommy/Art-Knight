using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reveal : MonoBehaviour
{
    public ObjectFade of;

    public UIFade UIF;
    public float count = 0; 
    public float timeLeft = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (of.nextStep == true)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                timeLeft = 0;
                of.FadeOutObject();
                timeLeft = 3;
            }
        }
        if (of.lastStep == true)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                timeLeft = 0;
                of.FakeFadeInObject();
            }
        }
        if (of.FadeScreen == true)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                timeLeft = 0;
                UIF.FadeInObject();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        count++;
        if (collider.gameObject.tag == "Player" && count == 1)
        {
            Debug.Log("THIS SHOULD REVEAL THE BOSS");
            of.FadeInObject();
        }
    }
}
