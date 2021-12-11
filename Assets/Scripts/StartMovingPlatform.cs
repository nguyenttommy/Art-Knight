using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMovingPlatform : MonoBehaviour
{
    public Lever lev;
    public FloatingHorizontalObject fho;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lev.lever)
        {
            fho.enabled = true;
        }
        else 
        {
            fho.enabled = false;
        }
    }
}
