using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timeLeft = 30.0f;
    float increaseSpeed = 0.0f;
    float decreaseSpeed = 0.0f;

    public Button slowDown;
    public Button speedUp;
    public Text time;



    void Start()
    {
        //Debug.Log("ONe");
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        //Debug.Log("two");
        while (timeLeft > 0.00f)
        {
            
            yield return new WaitForSecondsRealtime(0.001f - increaseSpeed + decreaseSpeed); //0.001
            timeLeft = timeLeft - Mathf.Abs(0.001f - increaseSpeed + decreaseSpeed);
            time.text = timeLeft.ToString();
            Debug.Log(timeLeft.ToString("0.00"));
        }
        if (timeLeft < 0.00f)
        {
            Debug.Log("Timer Has Run Out");
            time.text = "0";
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
