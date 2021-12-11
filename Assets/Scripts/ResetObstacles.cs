using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObstacles : MonoBehaviour
{
    public LevelManager lm;
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
        lm.playDeath = false;
    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        lm.playDeath = false;
    }
}
