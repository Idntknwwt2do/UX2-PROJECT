using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor;
using UnityEngine.UI;
public class ScreenManager : MonoBehaviour
{
public GameObject MenuScreen, LobbyScreen, QuestsScreen, RhupassBuyScreen,RhuPassUnlockedScreen,LockerScreen,ShopScreen,CareerScreen;
private GameObject ActiveScreen;
private Button ActiveButton;
public Button LobbyButton,QuestsButton,RPButton,LockerButton,CareerButton;
public PassManager passManager;

void Start()
{
    ActiveScreen = LobbyScreen;
    Debug.Log("Active Screen Is " + ActiveScreen);
    ActiveButton = LobbyButton;
}

public void ActivateLobbyScreen()
{
   
    if(ActiveScreen == LobbyScreen)
    {
    Debug.Log("Lobby Screen is already activated");       
    }
    else if (ActiveScreen != LobbyScreen)
    {
    ActiveScreen.transform.DOLocalMoveX(1941, .25f, true);
    Invoke("ChangeActiveScreenLobby",1.1f);
    LobbyScreen.transform.DOLocalMoveX(0,.25f, true);
    ActiveButton = LobbyButton;
    Invoke("LockActiveButton", 0f);
    Invoke("UnlockActiveButton",1f);
    }
}
public void ActivateQuestsScreen()
{
    if(ActiveScreen == QuestsScreen)
    {
        Debug.Log("Quest Screen is already activated");
    }
    else if (ActiveScreen != QuestsScreen)
    {
    ActiveScreen.transform.DOLocalMoveX(-1941,.25f,true);
    Invoke("ChangeActiveScreenQuest", 1.1f);
    QuestsScreen.transform.DOLocalMoveX(0,.25f, true);
    ActiveButton = QuestsButton;
    }
}
public void OpenPassScreen()
{
    if(passManager.PassBought == true)
{
        RhupassBuyScreen.SetActive(false);
        RhuPassUnlockedScreen.SetActive(true);
        RhuPassUnlockedScreen.transform.DOLocalMoveX(0,1f, true);
}
else if(passManager.PassBought == false)
{
    RhuPassUnlockedScreen.SetActive(false);
    RhupassBuyScreen.transform.DOLocalMoveX(0,1f,true);

}
}
private void ChangeActiveScreenQuest()
{
   ActiveScreen = QuestsScreen;
   Debug.Log("Active Screen is " + ActiveScreen);
}
private void ChangeActiveScreenLobby()
{
   ActiveScreen = LobbyScreen;
   Debug.Log("Active Screen is " + ActiveScreen);
}
private void LockActiveButon()
{
    
   ActiveButton.enabled = false;
   Debug.Log("Active Button" + ActiveButton + "Is Locked");
}
private void UnlockActiveButon()
{
    
   ActiveButton.enabled = true;
   Debug.Log("Active Button" + ActiveButton + "Is Unlocked");
}
}
