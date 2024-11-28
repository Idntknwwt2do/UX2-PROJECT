using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor;
using UnityEngine.UI;
using Unity.VisualScripting;
public class ScreenManager : MonoBehaviour
{
    public GameObject MenuScreen, LobbyScreen, QuestsScreen, RhupassBuyScreen, RhuPassUnlockedScreen, LockerScreen, ShopScreen, CareerScreen, PassBGCam, MainCam;
    private GameObject ActiveScreen;
    private Button ActiveButton;
    public Button LobbyButton, QuestsButton, RPButton, LockerButton, CareerButton;

    public PassManager passManager;
    public float ButtonCooldown;

    void Start()
    {
        ActiveScreen = LobbyScreen;
        Debug.Log("Active Screen Is " + ActiveScreen);
        ActiveButton = LobbyButton;
        ButtonCooldown = 0f;
    }

    public void ActivateLobbyScreen()
    {

        if (ActiveScreen == LobbyScreen)
        {
            Debug.Log("Lobby Screen is already activated");
        }
        else if (ActiveScreen != LobbyScreen)
        {
            ActiveScreen.transform.DOLocalMoveX(1941, .25f, true);

            Invoke("ChangeActiveScreenLobby", 1.1f);
            LobbyScreen.transform.DOLocalMoveX(0, .25f, true);
            ActiveButton = LobbyButton;
            Invoke("LockActButton", 0f);
         
        }
    }
    public void ActivateQuestsScreen()
    {
        if (ActiveScreen == QuestsScreen)
        {
            Debug.Log("Quest Screen is already activated");
        }
        else if (ActiveScreen != QuestsScreen)
        {
            ActiveScreen.transform.DOLocalMoveX(-1941, .25f, true);
            Invoke("ChangeActiveScreenQuest", 1.1f);
            QuestsScreen.transform.DOLocalMoveX(0, .25f, true);
            ActiveButton = QuestsButton;
            Invoke("LockActButton", 0f);
        }
    }
    public void OpenPassScreen()
    {
        if (passManager.PassBought == true && ActiveScreen)
        {
            ActiveScreen.transform.DOLocalMoveX(-1941, .25f, true);
            RhupassBuyScreen.SetActive(false);
            RhuPassUnlockedScreen.SetActive(true);
            RhuPassUnlockedScreen.transform.DOLocalMoveX(0, 1f, true);
            Invoke("ChangeActiveScreenRhuPass", 1f);
        }
        else if (passManager.PassBought == false && ActiveScreen)
        {
            ActiveScreen.transform.DOLocalMoveX(-1941, .25f, true);
            RhuPassUnlockedScreen.SetActive(false);
            RhupassBuyScreen.transform.DOLocalMoveX(0, 1f, true);
            Invoke("ChangeActiveCamPassBG", 0f);
            Invoke("ChangeActiveScreenRhuBuy", 1f);


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
    private void ChangeActiveScreenRhuBuy()
    {
        ActiveScreen = RhupassBuyScreen;
        Debug.Log("Active screen is " + ActiveScreen);
    }
    private void ChangeActiveScreenRhuPass()
    {
        ActiveScreen = RhuPassUnlockedScreen;
        Debug.Log("Active Screen is " + ActiveScreen);
    }

    public void ChangeActiveCamMain()
    {
        PassBGCam.SetActive(false);
        MainCam.SetActive(true);
    }
    void Update()
    {
        if (ButtonCooldown == 0f)
        {
            ButtonCooldown -= Time.deltaTime;
        }
    }
}
