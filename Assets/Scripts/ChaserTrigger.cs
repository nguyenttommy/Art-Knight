using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserTrigger : MonoBehaviour
{
    public LevelManager lm;
    public GameObject Object;
    public Transform respawnPoint;
    public int triggered = 0;
    void Update()
    {
        if (lm.playDeath)
        {
            triggered = 0;
            Object.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (triggered == 0)
        { Object.SetActive(true); Object.transform.position = respawnPoint.transform.position; }

        triggered++;
    }
}
//            
