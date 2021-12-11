using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{    public SpriteRenderer spriteRenderer;
    public Sprite draw;
    public bool check = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player entered");
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Blob")
            check = true;
        spriteRenderer.sprite = draw;
    }
}
