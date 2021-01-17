using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class bottom : MonoBehaviour
{
 
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                //Pickup();
                other.GetComponent<Rigidbody2D>().mass = .8f;
                SceneManager.LoadScene(sceneName: "Opening");
            }
        }
    
}
