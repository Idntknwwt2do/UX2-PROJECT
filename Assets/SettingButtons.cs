using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class SettingButtons : MonoBehaviour
{
    public List<GameObject> ScreenSizeButtons, ScreenSizeTXT,SettingsScreens; //Makes a list for the whitebuttons on the screen size object
    
    public AudioClip KeyPressed;

    public AudioSource src;

    void Start()
    {
        ScreenSizeButtons[2].SetActive(true);
        ScreenSizeTXT[2].SetActive(true);
    }
    public void SRLeftArrowButton()
    {
        src.clip = KeyPressed;
        src.Play();

        if (ScreenSizeButtons[0].activeSelf)
        {
            ScreenSizeButtons[4].SetActive(true);
            ScreenSizeTXT[4].SetActive(true);
            ScreenSizeTXT[0].SetActive(false);
            ScreenSizeButtons[0].SetActive(false);
            Screen.SetResolution(3840, 2160, FullScreenMode.Windowed); //Changes resolution

        }
        else if (ScreenSizeButtons[4].activeSelf)
        {
            ScreenSizeButtons[3].SetActive(true);
            ScreenSizeTXT[3].SetActive(true);
            ScreenSizeTXT[4].SetActive(false);
            ScreenSizeButtons[4].SetActive(false);
            Screen.SetResolution(3840, 2160, FullScreenMode.Windowed);

        }
        else if (ScreenSizeButtons[3].activeSelf)
        {
            ScreenSizeButtons[2].SetActive(true);
            ScreenSizeTXT[2].SetActive(true);
            ScreenSizeTXT[3].SetActive(false);
            ScreenSizeButtons[3].SetActive(false);
            Screen.SetResolution(2560, 1440, FullScreenMode.Windowed);

        }
        else if (ScreenSizeButtons[2].activeSelf)
        {
            ScreenSizeButtons[1].SetActive(true);
            ScreenSizeTXT[1].SetActive(true);
            ScreenSizeTXT[2].SetActive(false);
            ScreenSizeButtons[2].SetActive(false);
            Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);

        }
        else if (ScreenSizeButtons[1].activeSelf)
        {
            ScreenSizeButtons[0].SetActive(true);
            ScreenSizeTXT[0].SetActive(true);
            ScreenSizeTXT[1].SetActive(false);
            ScreenSizeButtons[1].SetActive(false);
            Screen.SetResolution(1366, 768, FullScreenMode.Windowed);

        }


    }
    public void SRRightArrowButton()
    {
        src.clip = KeyPressed;
        src.Play();
        if (ScreenSizeButtons[0].activeSelf)
        {
            ScreenSizeButtons[1].SetActive(true);
            ScreenSizeTXT[1].SetActive(true);
            ScreenSizeTXT[0].SetActive(false);
            ScreenSizeButtons[0].SetActive(false);
            Screen.SetResolution(1366, 768, FullScreenMode.Windowed);

        }
        else if (ScreenSizeButtons[4].activeSelf)
        {
            ScreenSizeButtons[0].SetActive(true);
            ScreenSizeTXT[0].SetActive(true);
            ScreenSizeTXT[4].SetActive(false);
            ScreenSizeButtons[4].SetActive(false);
            Screen.SetResolution(1280, 720, FullScreenMode.Windowed);

        }
        else if (ScreenSizeButtons[3].activeSelf)
        {
            ScreenSizeButtons[4].SetActive(true);
            ScreenSizeTXT[4].SetActive(true);
            ScreenSizeTXT[3].SetActive(false);
            ScreenSizeButtons[3].SetActive(false);
            Screen.SetResolution(3840, 2160, FullScreenMode.Windowed);

        }
        else if (ScreenSizeButtons[2].activeSelf)
        {
            ScreenSizeButtons[3].SetActive(true);
            ScreenSizeTXT[3].SetActive(true);
            ScreenSizeTXT[2].SetActive(false);
            ScreenSizeButtons[2].SetActive(false);
            Screen.SetResolution(2560, 1440, FullScreenMode.Windowed);

        }
        else if (ScreenSizeButtons[1].activeSelf)
        {
            ScreenSizeButtons[2].SetActive(true);
            ScreenSizeTXT[2].SetActive(true);
            ScreenSizeTXT[1].SetActive(false);
            ScreenSizeButtons[1].SetActive(false);
            Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
        }


    }
    public void OnClickSFX() //for other buttons on the settings menu
    {
        src.clip = KeyPressed;
        src.Play();
    }
    public void CloseScreens()
    {
        foreach(var Scr in SettingsScreens)
        {
            Scr.SetActive(false);
        }
    }

}
