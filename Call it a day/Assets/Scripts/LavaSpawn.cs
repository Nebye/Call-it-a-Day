using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class LavaSpawn : MonoBehaviour
{
    [SerializeField] private Sprite[] frameArray;
    private int currentFrame;
    private float timer;

    private void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer>= 1f)
        {
            timer = timer - 0.10f;
            currentFrame = (currentFrame + 1) % frameArray.Length;
            gameObject.GetComponent<SpriteRenderer>().sprite = frameArray[currentFrame];
        }
    }

    // if level starts trigger co-routine
    public void StartLavaFlood()
    {

    }

}
