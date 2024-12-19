using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LockerMenuManager : MonoBehaviour
{

    public GameObject CharactersScreen, HeadScreen, EyesScreen, GlovesScreen, MouthScreen, MiscScreen;
    private GameObject ActiveScreen;
    public AudioSource src;
    public AudioClip clickSfx1, clickSfx2;


    public void OpenCharacterScreen()
    {
        CharactersScreen.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine); //Scales the object up
        src.clip = clickSfx1;
        src.Play();
    }
    public void OpenHeadScreen()
    {
        HeadScreen.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine);
        src.clip = clickSfx1;
        src.Play();
    }
    public void OpenEyesScreen()
    {
        EyesScreen.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine);
        src.clip = clickSfx1;
        src.Play();
    }
    public void OpenGlovesScreen()
    {
        GlovesScreen.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine);
        src.clip = clickSfx1;
        src.Play();
    }
    public void OpenMouthScreen()
    {
        MouthScreen.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine);
        src.clip = clickSfx1;
        src.Play();
    }
    public void OpenMiscScreen()
    {
        MiscScreen.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine);
        src.clip = clickSfx1;
        src.Play();
    }
    public void CloseCharacterScreen()
    {
        CharactersScreen.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
        src.clip = clickSfx2;
        src.Play();
    }
    public void CloseHeadScreen()
    {
        HeadScreen.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
        src.clip = clickSfx2;
        src.Play();
    }
    public void CloseEyesScreen()
    {
        EyesScreen.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
        src.clip = clickSfx2;
        src.Play();
    }
    public void CloseGlovesScreen()
    {
        GlovesScreen.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
        src.clip = clickSfx2;
        src.Play();
    }
    public void CloseMouthScreen()
    {
        MouthScreen.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
        src.clip = clickSfx2;
        src.Play();
    }
    public void CloseMiscScreen()
    {
        MiscScreen.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
        src.clip = clickSfx2;
        src.Play();
    }


}
