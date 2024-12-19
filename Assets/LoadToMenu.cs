using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class LoadToMenu : MonoBehaviour
{
public GameObject LoadingScreen,PauseMenu,MenuCam,GameCam,GameUI;
public List <Button> MenuButtons; 
public List <GameObject> Menus;
public void ExitButtonCilck()
{
    LoadingScreen.SetActive(true);
    ClosePauseMenu();    
    MenuCam.SetActive(true);
    GameCam.SetActive(false);
    GameUI.SetActive(false);
    SetMenuButtonsActive();
}
public void ClosePauseMenu()
{
PauseMenu.transform.DOScale(new Vector3(0,0,0),0.1f);
PauseMenu.SetActive(false);
}
void SetMenuButtonsActive()
{
     foreach(var BTN in MenuButtons)
     {
        BTN.enabled = true;
     }
     foreach(var Scr in Menus)
     {
        Scr.SetActive(true);
     }
}
}
