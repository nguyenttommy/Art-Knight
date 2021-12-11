using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIFade : MonoBehaviour
{
    public bool fadeIn;
    public float fadeSpeed;
    public Color objectColor;
    public SceneChanger SC;
    // Start is called before the first frame update
    void Start()
    {

        objectColor = this.GetComponent<Image>().color;
        objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, 0);
        this.GetComponent<Image>().color = objectColor;

    }

    // Update is called once per frame
    void Update()
    {
        if (fadeIn)
        {

            Color objectColor = this.GetComponent<Image>().color;
            float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            this.GetComponent<Image>().color = objectColor;

            Debug.Log(objectColor.a);
            if (objectColor.a >= 1)
            {

                fadeIn = false;
                SC.StartMenu();
            }

        }
    }

    public void FadeInObject()
    {
        Debug.Log("Almost at the end");
        fadeIn = true;
    }
}
