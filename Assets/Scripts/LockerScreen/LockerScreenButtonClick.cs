using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerScreenButtonClick : MonoBehaviour
{
    public AudioSource src;
    public AudioClip Click;

    public void PlayClick()
    {
        src.clip = Click;
        src.Play();
    }
}
