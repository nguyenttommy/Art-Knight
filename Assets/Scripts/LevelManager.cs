using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
using UnityEngine.Audio;
public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public CinemachineVirtualCameraBase cam;

    public Transform respawnPoint;
    //public GameObject playerPrefab;

    //This is used to set the paint ammo for the level
    public int LevelRed;
    public int LevelBlue;
    public int LevelYellow;

    public GameObject player;
    public PlayerControlMove pcm;
    public Rigidbody2D rigidbody2D;

    public GameObject checkPoint;
    public GameObject checkPoint2,checkPoint3;

    public CheckPoint cp; 
    public CheckPoint cp2,cp3;

    public ResetPaint rp;

    public Text DeathCount;
    public static int deathCounter = 0;

    public Text Coin;
    public static int CoinCounter = 0;

    public PaintShot ps;

    public Timer t;

    //public ColorNumbers cn;
    public Block block;
    public bool playDeath = false;

    public AudioMixer audioMixer;

    private void Awake()
    {
        instance = this; 
        Time.timeScale = 1f;
        audioMixer.SetFloat("volume", PlayerPrefs.GetFloat("volume"));
    }
    public void Update()
    {
        DeathCount.text = "Death Count: " + deathCounter;

        Coin.text = "Paintings: " + CoinCounter;
        if (player.transform.position.y < -30)
        {
            playDeath = true;
            playerDeath();
        }
        //GameObject Player = Instantiate(playerPrefab,respawnPoint.position, Quaternion.identity);
        //cam.Follow = Player.transform;
        if (Input.GetButtonDown("Reset"))
        {
            if (!PauseMenu.GameIsPaused && !PaintStand.MenuOpen)
            {
            playDeath = true;
            playerDeath();
            }
        }

    }
    public void collect()
    {
        CoinCounter++;
    }
    public void playerDeath()
    {//This function is called when the player would die
        Debug.Log("Player has died");
        if(cp3.check)
            player.transform.position = checkPoint3.transform.position + new Vector3(0, 5, 0);
        else if (cp2.check)
            player.transform.position = checkPoint2.transform.position + new Vector3(0, 5,0);
        else if (cp.check)
            player.transform.position = checkPoint.transform.position + new Vector3(0, 5, 0);
        else
            player.transform.position = respawnPoint.transform.position;
        Debug.Log("Past the if statemetn");
        rp.ClearPaint();
        rp.ClearBlob();
        rp.clean = true;
        ps.resetPaint();
        ps.TrackUpdate();
        deathCounter += 1;
        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 0);
        pcm.reset();
        t.RestartTime();
    }
    public bool BuyPaint()
    {
        if (CoinCounter >= 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void SpendMoney()
    {
        CoinCounter -= 3;
    }
}
