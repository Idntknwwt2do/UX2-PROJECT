using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Palmmedia.ReportGenerator.Core;
using UnityEngine;

public class SubMenuButtons : MonoBehaviour
{
    //FriendsListScroll Voids made Using Microsoft Copilot. Prompt 'I would like to move an object on the Y axis the same amount multiple times with a button'
    public GameObject FriendsScreen, ExtraMenuScreen, SettingsMenuScreen, ReportPlayerPanel, SupportScreen, CreditsScreen;
    public Transform FriendsList;
    public AudioSource Src;
    public AudioClip ClickSound1;
    public AudioClip ClickSound2;


    public void OpenFriendsScreen()
    {
        FriendsScreen.transform.DOLocalMoveX(-777, .5f, true).SetEase(Ease.InOutQuad);
        Src.clip = ClickSound1;
        Src.Play();
    }
    public void CloseFriendsScreen()
    {
        FriendsScreen.transform.DOLocalMoveX(-1291, .5f, true).SetEase(Ease.InOutQuad);
    }

    public void OpenExtraMenu()
    {
        ExtraMenuScreen.transform.DOLocalMoveX(701, .5f, true);
        Src.clip = ClickSound1;
        Src.Play();
    }
    public void CloseExtraMenu()
    {
        ExtraMenuScreen.transform.DOLocalMoveX(1291, .5f, true);
    }
    public void FriendsListScrollDown()
    {
        FriendsList.DOMoveY(FriendsList.position.y + 50, .1f, true);
        Src.clip = ClickSound1;
        Src.Play();
    }
    public void FriendsListScrollUp()
    {
        FriendsList.DOMoveY(FriendsList.position.y + -50, .1f, true);
        Src.clip = ClickSound2;
        Src.Play();
    }
    public void OpenSettingsMenu()
    {
        SettingsMenuScreen.transform.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.OutSine);
    }
    public void CloseSettingsMenu()
    {
        SettingsMenuScreen.transform.DOScale(new Vector3(1,1,1),1f).SetEase(Ease.OutSine);
    }
    public void OpenReportPanel()
    {
        ReportPlayerPanel.transform.DOScale(new Vector3(1,1,1),.5f).SetEase(Ease.OutSine);
    }
    public void CloseReportPanel()
    {
        ReportPlayerPanel.transform.DOScale(new Vector3(0,0,0), .5f).SetEase(Ease.OutSine);
    }
    public void OpenCreditsPanel()
    {
        CreditsScreen.transform.DOScale(new Vector3(1,1,1),.5f).SetEase(Ease.OutSine);
    }
    public void CloseCreditsPanel()
    {
        CreditsScreen.transform.DOScale(new Vector3(0,0,0),.5f).SetEase(Ease.OutSine);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
