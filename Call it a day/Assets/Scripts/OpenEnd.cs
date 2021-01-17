using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OpenEnd : MonoBehaviour
{
    public Text placeHolder01;
    public Text placeHolder02;

    public Text YourTime;
    public Text HighScore;


    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetFloat("YourCurrentScore", 0.00f);
        //PlayerPrefs.SetFloat("Hscore", 0.00f);

        if (PlayerPrefs.GetFloat("YourCurrentScore") <= 0.00f)
        {
            placeHolder01.gameObject.SetActive(false);
            placeHolder02.gameObject.SetActive(false);

            YourTime.gameObject.SetActive(false);
            HighScore.gameObject.SetActive(false);
        }
        YourTime.text = PlayerPrefs.GetFloat("YourCurrentScore").ToString();
        HighScore.text = PlayerPrefs.GetFloat("Hscore").ToString();

    }

}
