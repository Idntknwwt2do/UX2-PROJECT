using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor;
using UnityEngine.UI;
public class ScreenManager : MonoBehaviour
{
    public GameObject MenuScreen, LobbyScreen, QuestsScreen, RhupassBuyScreen, RhuPassUnlockedScreen, LockerScreen, ShopScreen, CareerScreen, PassBGCam, MainCam;
    private GameObject ActiveScreen;
    private Button ActiveButton;
    public Button LobbyButton, QuestsButton, RPButton, LockerButton, ShopButton, CareerButton;

    public PassManager passManager;

    public float ButtonCooldown, ButtonInteractChecker = 1f;

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

            Invoke("ChangeActiveScreenLobby", 0.3f);
            LobbyScreen.transform.DOLocalMoveX(0, .25f, true);
            ActiveButton = LobbyButton;
            Invoke("LockAllButtons", 0.1f);
            Invoke("UnlockAllButtons", 0.25f);

        }
        else if (LobbyButton.interactable == false)
        {
            Debug.Log("LobbyButton Locked");
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
            ActiveScreen.transform.DOLocalMoveX(1941, .25f, true);
            Invoke("ChangeActiveScreenQuest", 0.3f);
            QuestsScreen.transform.DOLocalMoveX(0, .25f, true);
            ActiveButton = QuestsButton;
            Invoke("LockAllButtons", 0.1f);
            Invoke("UnlockAllButtons", 0.5f);

        }
        else if (QuestsButton.interactable == false)
        {
            Debug.Log("QuestButton Locked");
        }
    }
    public void OpenPassScreen()
    {
        if (passManager.PassBought == true && ActiveScreen != RhuPassUnlockedScreen)
        {
            ActiveScreen.transform.DOLocalMoveX(1941, .25f, true);
            RhupassBuyScreen.SetActive(false);
            RhuPassUnlockedScreen.SetActive(true);
            RhuPassUnlockedScreen.transform.DOLocalMoveX(0, 0.3f, true);
            Invoke("ChangeActiveScreenRhuPass", 0.3f);
            Invoke("LockAllButtons", 0.1f);
            Invoke("UnlockAllButtons", 0.5f);
        }
        else if (passManager.PassBought == false && ActiveScreen != RhupassBuyScreen)
        {
            ActiveScreen.transform.DOLocalMoveX(1941, .25f, true);
            RhuPassUnlockedScreen.SetActive(false);
            RhupassBuyScreen.transform.DOLocalMoveX(0, 0.3f, true);
            Invoke("ChangeActiveCamPassBG", 0f);
            Invoke("ChangeActiveScreenRhuBuy", 0.3f);
            Invoke("LockAllButtons", 0.1f);
            Invoke("UnlockAllButtons", 0.5f);
        }
        else if (RPButton.interactable == false)
        {
            Debug.Log("PassButtonLocked");
        }
    }
    public void OpenLockerScreen()
    {
        Invoke("ChangeActiveScreenLocker", 0.3f);
        ActiveScreen.transform.DOLocalMoveX(1941, .25f, true);
        LockerScreen.transform.DOLocalMoveX(0, 0.3f, true);
        Invoke("LockAllButtons", 0.1f);
        Invoke("UnlockAllButtons", 0.5f);

    }
    public void OpenShopScreen()
    {
        Invoke("ChangeActiveScreenShop", 0.3f);
        ActiveScreen.transform.DOLocalMoveX(1941, .25f, true);
        ShopScreen.transform.DOLocalMoveX(0, 0.3f, true);
        Invoke("LockAllButtons", 0.1f);
        Invoke("UnlockAllButtons", 0.5f);
    }
    private void ChangeActiveScreenLocker()
    {
        ActiveScreen = LockerScreen;
        ActiveButton = LockerButton;
        Debug.Log("Active Screen is" + ActiveScreen);
    }

    private void ChangeActiveScreenQuest()
    {
        ActiveScreen = QuestsScreen;
        ActiveButton = QuestsButton;
        Debug.Log("Active Screen is " + ActiveScreen);
    }
    private void ChangeActiveScreenLobby()
    {
        ActiveScreen = LobbyScreen;
        ActiveButton = LobbyButton;
        Debug.Log("Active Screen is " + ActiveScreen);
    }
    private void ChangeActiveScreenRhuBuy()
    {
        ActiveScreen = RhupassBuyScreen;
        ActiveButton = RPButton;
        Debug.Log("Active screen is " + ActiveScreen);
    }
    private void ChangeActiveScreenRhuPass()
    {
        ActiveScreen = RhuPassUnlockedScreen;
        ActiveButton = RPButton;
        Debug.Log("Active Screen is " + ActiveScreen);
    }
    private void ChangeActiveScreenShop()
    {
        ActiveScreen = ShopScreen;
        ActiveButton = ShopButton;
        Debug.Log("Active Screen is " + ActiveScreen);
    }

    public void ChangeActiveCamMain()
    {
        PassBGCam.SetActive(false);
        MainCam.SetActive(true);

        //Changes Active Cameras for the RhuPass purchase screen
    }


    void LockAllButtons()
    {
        LobbyButton.interactable = false;
        QuestsButton.interactable = false;
        RPButton.interactable = false;
        LockerButton.interactable = false;
        CareerButton.interactable = false;
        //Locks All buttons, this is done to make it a little harder to recreate a bug where the Lobby Screen Items would show up over the other screens
    }
    void UnlockAllButtons()
    {
        LobbyButton.interactable = true;
        QuestsButton.interactable = true;
        RPButton.interactable = true;
        LockerButton.interactable = true;
        CareerButton.interactable = true;
        //Unlocks All Buttons
    }
    void Update()
    {
        if (ButtonInteractChecker == 0f)
        {
            LobbyButton.interactable = true;
            QuestsButton.interactable = true;
            RPButton.interactable = true;
            LockerButton.interactable = true;
            CareerButton.interactable = true;
            ButtonInteractChecker = 1f;
            //Sets all buttons to be interactable every second, this was done to prevent a bug where clicking the bottom buttons really fast would cause them to stay uninteractable
        }
        ButtonInteractChecker -= Time.deltaTime;
        ButtonInteractChecker = Mathf.Clamp(ButtonInteractChecker, 0f, 1f); //Stops the timer from going underneath 0. 
    }

}
