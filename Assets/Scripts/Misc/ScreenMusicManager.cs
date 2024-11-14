using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMusicManager : MonoBehaviour
{
    public GameObject MMScreen, LBScreen;
    public AudioSource src;
    public AudioClip MMMusic;

    [System.Obsolete]
    void Start()
    {
        if (MMScreen.active)
        {
            src.clip = MMMusic;
            src.Play();
        }
    
    }
}
