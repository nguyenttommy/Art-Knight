using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPoint : MonoBehaviour
{
    public LevelManager lm;
    public GameObject Object;
    public bool enemy = false;
    //public Transform point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lm.playDeath)
        {
            Debug.Log("On player death, I'll create a rock");
            if(!enemy)
            Object.SetActive(true);
        }
    }
}
