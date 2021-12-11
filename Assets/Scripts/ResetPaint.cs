using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPaint : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject[] gameObjectsRed;
    GameObject[] gameObjectsBlue;
    GameObject[] gameObjectsYellow;
    GameObject[] gameObjectsBlob;
    GameObject[] gameObjectsRed2;
    GameObject[] gameObjectsRed3;


    GameObject[] numbers;
    //public ColorNumbers cn;
    public PaintShot ps;

    public bool clean = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        clean = false;
    }
    void OnTriggerEnter2D(Collider2D push)
    {
        ClearPaint();
        ps.resetPaint();
        ps.TrackUpdate();
        clean = true;
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        clean = false;
    }

    public void ClearPaint()
    {
        gameObjectsRed = GameObject.FindGameObjectsWithTag("RED");
        gameObjectsBlue = GameObject.FindGameObjectsWithTag("BLUE");
        gameObjectsYellow = GameObject.FindGameObjectsWithTag("YELLOW");
        gameObjectsRed2 = GameObject.FindGameObjectsWithTag("Red2");
        gameObjectsRed3 = GameObject.FindGameObjectsWithTag("Red3");
        gameObjectsBlob = GameObject.FindGameObjectsWithTag("Blob");
        //numbers = GameObject.FindGameObjectsWithTag("Number");
        for (var i = 0; i < gameObjectsRed.Length; i++)
        {
            Destroy(gameObjectsRed[i]);
        }
        for (var i = 0; i < gameObjectsBlue.Length; i++)
        {
            Destroy(gameObjectsBlue[i]);
        }
        for (var i = 0; i < gameObjectsYellow.Length; i++)
        {
            Destroy(gameObjectsYellow[i]);
        }
        for (var i = 0; i < gameObjectsBlob.Length; i++)
        {
            Destroy(gameObjectsBlob[i]);
        }
        for (var i = 0; i < gameObjectsRed2.Length; i++)
        {
            Destroy(gameObjectsRed2[i]);
        }
        for (var i = 0; i < gameObjectsRed3.Length; i++)
        {
            Destroy(gameObjectsRed3[i]);
        }

    }
    public void ClearBlob()
    {
        gameObjectsBlob = GameObject.FindGameObjectsWithTag("Blob");
        for (var i = 0; i < gameObjectsBlob.Length; i++)
        {
            Destroy(gameObjectsBlob[i]);
        }
    }
}
