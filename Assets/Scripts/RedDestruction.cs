using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDestruction : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "RedBlob" && collider.gameObject.layer == 10)
        {//This means the incoming bullet is another red and this current paint is either Red1 or Red2 and needs to be destroyed.
            Destroy(gameObject);
        }
    }
}
