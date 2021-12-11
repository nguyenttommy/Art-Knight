using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMovingVerticalPlatform : MonoBehaviour
{
    public Lever lev;
    public FloatingObject fo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lev.lever)
        {
            fo.enabled = true;
        }
        else
        {
            fo.enabled = false;
        }
    }
}
