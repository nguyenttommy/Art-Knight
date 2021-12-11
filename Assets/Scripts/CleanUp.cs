using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUp : MonoBehaviour
{//Original purpose of this script was to delete a paint block when one would be made on top of it
    public GameObject block;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("Trigger! Something is still on me!");
        //These next few lines of code tells Arthur what color paint he is standing on.
        //Destroy(gameObject);
        if (collider.gameObject.tag == "Cleaner" && block.gameObject.tag != "YELLOW")
        {
            Destroy(gameObject);
            //This means that the block disappears when an enemy is on top of it

            //ai.cleanAnimation();
            //Change it so that it takes some time before it removes the block
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        //Debug.Log("Trigger! Something is still on me!");
        //These next few lines of code tells Arthur what color paint he is standing on.
        //Destroy(gameObject);
        if (collider.gameObject.tag == "Cleaner")
        {

            Destroy(gameObject);
            //This means that the block disappears when an enemy is on top of it

            //ai.cleanAnimation();
            //Change it so that it takes some time before it removes the block
        }
    }

}
