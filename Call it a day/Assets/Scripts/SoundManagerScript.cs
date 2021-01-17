﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioClip playerJumpSound, bgmSound;
    static AudioSource audioSrc;
    void Start()
    {
        playerJumpSound = Resources.Load<AudioClip> ("Whoosh");
        bgmSound = Resources.Load<AudioClip> ("adventure-8bit_actual");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch(clip)
        {
            case "Whoosh":
                audioSrc.PlayOneShot(playerJumpSound);
                break;
        }
    }
}
