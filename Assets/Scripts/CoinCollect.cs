using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public GameObject coin;
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
    { //if player is dashing or jumping, destroy object

        if (collider.gameObject.tag == "Player")
        {
            coin.SetActive(false);
            lm.collect();
        }

    }
}
