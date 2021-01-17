using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LastTile : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Pickup();
            other.GetComponent<Rigidbody2D>().mass = .8f;
            if (PlayerPrefs.GetFloat("Hscore") >= PlayerPrefs.GetFloat("YourCurrentScore") || PlayerPrefs.GetFloat("Hscore") == 0.00f) // Sets High Score if new High Score Reached
            {
                PlayerPrefs.SetFloat("Hscore", PlayerPrefs.GetFloat("YourCurrentScore"));
                Debug.Log("New Lowest Time: " + PlayerPrefs.GetFloat("Hscore"));
            }
            SceneManager.LoadScene(sceneName: "Opening");
        }
    }
}
