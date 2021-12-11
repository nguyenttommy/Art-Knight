using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float OriginalTime = 120;
    public float timeLeft; 

    public bool timerIsRunning = false;

    public Text timeText;
    public LevelManager lm;
    // Update is called once per frame
    void Start()
    {
        timeLeft = OriginalTime;
        timerIsRunning = true;
    }
    
    void Update()
    {//On player death, reset timer
        if (timerIsRunning)
        { 
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                DisplayTime(timeLeft);
            }
            else 
            {
                Debug.Log("Time has run out!");
                timeLeft = 0;
                timerIsRunning = false;
                lm.playerDeath();
                //RestartTime();
                //Player dies
            }
        }
    }
    public void RestartTime()
    {
        Debug.Log("Restart Time");
        timeLeft = OriginalTime;
        timerIsRunning = true;
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay/60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
