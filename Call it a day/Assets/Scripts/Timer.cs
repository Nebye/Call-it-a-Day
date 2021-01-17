using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timeLeft = 00.0f;
    float increaseSpeed = 0.0f;
    float decreaseSpeed = 0.0f;

    public Button slowDown;
    public Button speedUp;
    public Text time;

    public Text YourTime;
    public Text HighScore;


    void Start()
    {
        //Debug.Log("ONe");
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        //Debug.Log("two");
        while (SceneManager.GetActiveScene().name == "JumpMan")
        {
            
            yield return new WaitForSecondsRealtime(0.0001f - increaseSpeed + decreaseSpeed); //0.001
            timeLeft = timeLeft + Mathf.Abs(0.001f - increaseSpeed + decreaseSpeed);
            time.text = timeLeft.ToString();
            //Debug.Log(timeLeft.ToString("n2"));
            PlayerPrefs.SetFloat("YourCurrentScore", timeLeft);
            //if (PlayerPrefs.GetFloat("Hscore") >= timeLeft) // Sets High Score if new High Score Reached
            //{
            //    PlayerPrefs.SetFloat("Hscore", timeLeft);
            //    Debug.Log("New Lowest Time: "+ PlayerPrefs.GetFloat("Hscore"));
            //}
            
        }
    }


    public void SlowDown()
    {
        if (decreaseSpeed == 1.0f)
        {
            
        }
        else
        {
            decreaseSpeed = decreaseSpeed + 0.01f;
        }
    }

    public void SpeedUp()
    {
        if (increaseSpeed == 1.00f)
        {
            
        }
        else
        {
            increaseSpeed = increaseSpeed + 0.01f;
        }
        
    }

}
