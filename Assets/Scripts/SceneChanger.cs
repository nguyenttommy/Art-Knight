using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public bool OneTwo;
    public bool OneThree;
    public bool OneFour;
    public bool OneFive;//To be changed when we have a next level
    public bool OneSix;

    public void StartMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start");
    }
     
    public void ChangeScene11()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("1-1 Tutorial Red");
    }
    public void ChangeScene12()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("1-2 Tutorial Blue");
    }
    public void ChangeScene13()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("1-3 Tutorial Yellow");
    }
    public void ChangeScene14()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("1-4 Tutorial Stack");
    }
    public void ChangeScene15()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Real 1-5");
    }
    public void ChangeScene16()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Real 1-6");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (OneTwo)
            {
                ChangeScene12();
            }
            else if (OneThree)
            {
                ChangeScene13();
            }
            else if (OneFour)
            {
                ChangeScene14();
            }
            else if (OneFive)
            {
                ChangeScene15();
            }
            else if (OneSix)
            {
                ChangeScene16();
            }
        }

    }
}
