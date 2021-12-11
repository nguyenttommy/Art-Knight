using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintSwap : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite Red;
    public Sprite Yellow;
    public Sprite Blue;
    public bool RedPaint;
    public bool BluePaint;
    public bool YellowPaint;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        RedPaint = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.GameIsPaused)
        { 
            if (Input.GetButtonDown("Blue Paint") && GameObject.Find("Paint Blob(Clone)") == null)
            {
                spriteRenderer.sprite = Blue;
                RedPaint = false;
                BluePaint = true;
                YellowPaint = false;
                animator.SetBool("Blue",true); 
                animator.SetBool("Red", false); 
                animator.SetBool("Yellow", false);
            }
            else if (Input.GetButtonDown("Red Paint") && GameObject.Find("Paint Blob(Clone)") == null)
            {
                spriteRenderer.sprite = Red;
                RedPaint = true;
                BluePaint = false;
                YellowPaint = false; 
                animator.SetBool("Blue", false);
                animator.SetBool("Red", true); 
                animator.SetBool("Yellow", false);
            }
            else if (Input.GetButtonDown("Yellow Paint") && GameObject.Find("Paint Blob(Clone)") == null)
            {
                spriteRenderer.sprite = Yellow;
                RedPaint = false;
                BluePaint = false;
                YellowPaint = true; 
                animator.SetBool("Blue", false);
                animator.SetBool("Red", false);
                animator.SetBool("Yellow", true);
            }
        }
    }
}
