using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFade : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite Joke;
    public  bool fadeOut, fadeIn, FakefadeIn, nextStep, lastStep, FadeScreen;
    public float fadeSpeed;


    public Color objectColor;
    // Start is called before the first frame update
    void Start()
    {
        objectColor = this.GetComponent<Renderer>().material.color;
        objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, 0);
        this.GetComponent<Renderer>().material.color = objectColor;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.H) && !fadeIn)
        {
            FadeOutObject();
        }
        if (Input.GetKeyDown(KeyCode.J) && !fadeOut)
        {
            FadeInObject();
        }
        */
        if (fadeOut)
        {
            Color objectColor = this.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            this.GetComponent<Renderer>().material.color = objectColor;

            if (objectColor.a <= 0)
            {
                nextStep = false;
                fadeOut = false; 
                spriteRenderer.sprite = Joke;
                lastStep = true;
            }

        }
        if (fadeIn)
        {
            Color objectColor = this.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            this.GetComponent<Renderer>().material.color = objectColor;

            if (objectColor.a >= 1)
            {
                fadeIn = false;
                nextStep = true;
            }

        }
        if (FakefadeIn)
        {
            Color objectColor = this.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            this.GetComponent<Renderer>().material.color = objectColor;

            if (objectColor.a >= 1)
            {
                FakefadeIn = false;
                lastStep = false;
                FadeScreen = true;
            }

        }

        /*
        if (objectColor.a >= 1)
        {

        }
        if (objectColor.a <= 0)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                timeLeft = 0;
                FadeInObject();
            }
        }
        */

    }
    public void FadeOutObject()
    {
        fadeOut = true;
    }
    public void FadeInObject()
    {
        Debug.Log("FadeIN");
        fadeIn = true;
    }
    public void FakeFadeInObject()
    {
        Debug.Log("FadeIN");
        FakefadeIn = true;
    }
}
