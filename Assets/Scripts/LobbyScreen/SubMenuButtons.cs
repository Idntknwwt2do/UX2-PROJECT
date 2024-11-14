using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SubMenuButtons : MonoBehaviour
{
    //FriendsListScroll Voids made Using Microsoft Copilot. Prompt 'I would like to move an object on the Y axis the same amount multiple times with a button'
    public GameObject FriendsScreen, ExtraMenuScreen;
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
}
