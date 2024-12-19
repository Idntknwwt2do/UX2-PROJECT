using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadGame : MonoBehaviour
{
    public List<GameObject> Menus;
    public List<Button> Menubuttons;
    public GameObject readyTXT, NotReadyTXT, MenuCam, GameCam,LoadingScreen;
    public AudioSource src;
    public AudioClip ButtonPress;


    public void Load()
    {
        foreach (var scr in Menus)
        {
            scr.SetActive(false);
        }
        foreach (var BTN in Menubuttons)
        {
            BTN.enabled = false;
        }
        LoadingScreen.SetActive(true);
        MenuCam.SetActive(false);
        GameCam.SetActive(true);
        SetReadyActive();
        Invoke("SetButtonsActive",15f);

    }


    public void PlayBTNPress()
    {
        Invoke("Load", 5f);
        foreach (var BTN in Menubuttons)
        {
            BTN.enabled = false;
        }
    }
    public void SetReadyActive()
    {
        readyTXT.SetActive(true);
        NotReadyTXT.SetActive(false);
    }
    public void SetButtonsActive()
    {
        foreach(var BTN in Menubuttons)
        {
            BTN.enabled = true;
        }
    }


}
