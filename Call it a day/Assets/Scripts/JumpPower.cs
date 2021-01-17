using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPower : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Pickup();
            other.GetComponent<Rigidbody2D>().mass = .8f;
            Destroy(gameObject);
        }
    }
    

    
}
