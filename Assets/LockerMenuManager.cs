using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LockerMenuManager : MonoBehaviour
{

    public GameObject CharactersScreen,HeadScreen,EyesScreen,GlovesScreen,MouthScreen,MiscScreen;
    private GameObject ActiveScreen;

    void SetActiveScreenChara()
    {
        ActiveScreen = CharactersScreen;
    }
    void SetActiveScreenHead()
    {
        ActiveScreen = HeadScreen;
    }
    void SetActiveScreenEyes()
    {
        ActiveScreen = EyesScreen;
    }
    void SetActiveScreenGloves()
    {
        ActiveScreen = GlovesScreen;
    }
    void SetActiveScreenMouth()
    {
        ActiveScreen = MouthScreen;
    }
    void SetActiveScreenMisc()
    {
        ActiveScreen = MiscScreen;
    }
    public void OpenCharacterScreen()
    {
        CharactersScreen.transform.DOScale(new Vector3(1,1,1),.5f).SetEase(Ease.OutSine);
    }
    public void OpenHeadScreen()
    {
        HeadScreen.transform.DOScale(new Vector3(1,1,1),.5f).SetEase(Ease.OutSine);
    }
    public void OpenEyesScreen()
    {
        EyesScreen.transform.DOScale(new Vector3(1,1,1),.5f).SetEase(Ease.OutSine);
    }
    public void OpenGlovesScreen()
    {
        GlovesScreen.transform.DOScale(new Vector3(1,1,1),.5f).SetEase(Ease.OutSine);
    }
    public void OpenMouthScreen()
    {
        MouthScreen.transform.DOScale(new Vector3(1,1,1),.5f).SetEase(Ease.OutSine);
    }
    public void OpenMiscScreen()
    {
        MiscScreen.transform.DOScale(new Vector3(1,1,1),.5f).SetEase(Ease.OutSine);
    }
    public void CloseCharacterScreen()
    {
        CharactersScreen.transform.DOScale(new Vector3(0,0,0),.5f).SetEase(Ease.OutSine);
    }
    public void CloseHeadScreen()
    {
        HeadScreen.transform.DOScale(new Vector3(0,0,0),.5f).SetEase(Ease.OutSine);
    }
    public void CloseEyesScreen()
    {
        EyesScreen.transform.DOScale(new Vector3(0,0,0),.5f).SetEase(Ease.OutSine);
    }
    public void CloseGlovesScreen()
    {
        GlovesScreen.transform.DOScale(new Vector3(0,0,0),.5f).SetEase(Ease.OutSine);
    }
    public void CloseMouthScreen()
    {
        MouthScreen.transform.DOScale(new Vector3(0,0,0),.5f).SetEase(Ease.OutSine);
    }
    public void CloseMiscScreen()
    {
        MiscScreen.transform.DOScale(new Vector3(0,0,0),.5f).SetEase(Ease.OutSine);
    }


}
