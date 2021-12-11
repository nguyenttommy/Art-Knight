using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public LevelManager lm;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(this.name);
        if (collision.gameObject.tag == "Player")
        {
            //gameObject.transform.position = LevelManager.instance.respawnPoint.position;
            // reset.ClearPaint(); ps.resetPaint();
            // ps.TrackUpdate();
            //Application.LoadLevel(Application.loadedLevel);
            lm.playerDeath();
            lm.playDeath = true;
        }
        //Debug.Log(this.gameObject.tag);
        if (this.gameObject.tag == "Player" && collision.gameObject.tag == "Enemy")
        {
            lm.playerDeath();
            lm.playDeath = true;
        }
    }
    void Update()
    { 
        /*if (gameObject.transform.position.y < -30)
        {
            //Destroy(gameObject);

            //LevelManager.instance.Respawn();   

            //gameObject.transform.position = LevelManager.instance.respawnPoint.position;
            //reset.ClearPaint(); ps.resetPaint();
            //ps.TrackUpdate();
            Application.LoadLevel(Application.loadedLevel);
        }
        */
    }

}
