using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider;
    public AudioSource MusicSrc, SfxSrc1, SfxSrc2;


    public void ChangeSfxVolume()
    {
        SfxSrc1.volume = VolumeSlider.value;
        SfxSrc2.volume = VolumeSlider.value;
    }
    public void ChangeMusicVolume()
    {
        MusicSrc.volume = VolumeSlider.value;
    }
    public void ChangeMasterVolume()
    {
        SfxSrc1.volume = VolumeSlider.value;
        SfxSrc2.volume = VolumeSlider.value;
        MusicSrc.volume = VolumeSlider.value;
    }
}
