using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
 
public class PaintShot : MonoBehaviour
{//Make this have limited paint shots

    public Transform firePoint;
    public GameObject bulletPrefab;

    public static int MaxRedAmmo =10;
    public static int MaxBlueAmmo =10;
    public static int MaxYellowAmmo =10;

    public int RedAmmo;
    public int BlueAmmo;
    public int YellowAmmo;
    public PaintSwap ps;

    public RectTransform Red;
    public RectTransform Blue;
    public RectTransform Yellow;

    private float maxPaintWidth = 315.79f;

    public Text RedT;
    public Text BlueT;
    public Text YellowT;

    public Animator animator;
    // Update is called once per frame
    void Start()
    {
        /*
        MaxRedAmmo = LevelManager.instance.LevelRed;
        MaxBlueAmmo = LevelManager.instance.LevelBlue;
        MaxYellowAmmo = LevelManager.instance.LevelYellow;
        */

        RedAmmo = MaxRedAmmo;
        BlueAmmo = MaxBlueAmmo;
        YellowAmmo = MaxYellowAmmo;
    }
    void Update()
    {

        //This is used when Arthur uses paint or gets paint refilled.
        RedT.text = RedAmmo + " / " + MaxRedAmmo;
        BlueT.text = BlueAmmo + " / " + MaxBlueAmmo;
        YellowT.text = YellowAmmo + " / " + MaxYellowAmmo;
        if (!PauseMenu.GameIsPaused && !PaintStand.MenuOpen)
        {
            //This shoots a paint blob when the button is fired. This only works when there is still paint left to be used of the color
            ps = FindObjectOfType<PaintSwap>();
        if (ps.RedPaint == true)
        { 
            if (Input.GetButtonUp("Fire1") && RedAmmo > 0)//Left mouse by default
            {
                animator.Play("ThrowingRed");
                Shoot();
                RedAmmo -= 1;
                TrackUpdate();
            }
        }
        else if (ps.BluePaint == true)
        {
            if (Input.GetButtonUp("Fire1") && BlueAmmo > 0)//Left mouse by default
            {
                animator.Play("ThrowingBlue");
                Shoot();
                BlueAmmo -= 1;
                TrackUpdate();
            }
        }
        else if (ps.YellowPaint == true)
        {
            if (Input.GetButtonUp("Fire1") && YellowAmmo > 0)//Left mouse by default
            {
                animator.Play("ThrowingYellow"); 
                Shoot();
                YellowAmmo -= 1;
                TrackUpdate();
            }
        }
        }
    }



    public bool RedCheck()
    {
        if (RedAmmo < MaxRedAmmo)
        { 
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool BlueCheck()
    {
        if (BlueAmmo < MaxBlueAmmo)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool YellowCheck()
    {
        if (YellowAmmo < MaxYellowAmmo)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void RedUp()
    {
        RedAmmo++; TrackUpdate();
    }
    public void BlueUp()
    {
        BlueAmmo++; TrackUpdate();
    }
    public void YellowUp()
    {
        YellowAmmo++; TrackUpdate();
    }

    //This creates a paint blob and shoots it
    void Shoot()
    {
        //Shooting logic
        //animator.SetBool("Shoot", true);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        //animator.SetBool("Shoot", false);
    }
    //This refills the color ammo to max
    public void resetPaint()
    {
        RedAmmo = MaxRedAmmo;
        BlueAmmo = MaxBlueAmmo;
        YellowAmmo = MaxYellowAmmo;
    }
    public void TrackUpdate()
    {
        Red.DOSizeDelta(new Vector2((float)RedAmmo / MaxRedAmmo * maxPaintWidth, Red.sizeDelta.y), .5f);
        Blue.DOSizeDelta(new Vector2((float)BlueAmmo / MaxBlueAmmo * maxPaintWidth, Blue.sizeDelta.y), .5f);
        Yellow.DOSizeDelta(new Vector2((float)YellowAmmo / MaxYellowAmmo * maxPaintWidth, Yellow.sizeDelta.y), .5f);
    }
    public void ReplenishRed()
    {
        if (RedAmmo > MaxRedAmmo - 5)
        {
            RedAmmo = MaxRedAmmo;
        }
        else 
            RedAmmo += 5;
    }
    public void ReplenishBlue()
    {
        if (BlueAmmo > MaxBlueAmmo - 5)
        {
            BlueAmmo = MaxBlueAmmo;
        }
        else
            BlueAmmo += 5;
    }
    public void ReplenishYellow()
    {
        if (YellowAmmo > MaxYellowAmmo - 5)
        {
            YellowAmmo = MaxYellowAmmo;
        }
        else
            YellowAmmo += 5;
    }
    public void PlusOneRed()
    {
        MaxRedAmmo++;
        ReplenishRed(); 
        TrackUpdate();
    }
    public void PlusOneBlue()
    {
        MaxBlueAmmo++; 
        ReplenishBlue(); 
        TrackUpdate();
    }
    public void PlusOneYellow()
    {
        MaxYellowAmmo++; 
        ReplenishYellow(); 
        TrackUpdate();
    }
}
 