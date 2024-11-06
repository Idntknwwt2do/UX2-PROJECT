using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SelectModeButtons : MonoBehaviour
{
public Vector3 ScaleTo; 
public GameObject SMButton, SMScreen, SOButton, DButton, TButton, SQButton;
public void SMButtonSelected()
{
    SMScreen.transform.DOScale(new Vector3(1,1,1), .5f).SetEase(Ease.OutSine);
}
public void SoloButtonselected()
{
    SOButton.transform.DOScale(ScaleTo, .5f).SetEase(Ease.OutSine).SetLoops(2, LoopType.Yoyo);
    Invoke("DelaySetInactive", 1.0f);
}
public void DuoButtonselected()
{
    DButton.transform.DOScale(ScaleTo, .5f).SetEase(Ease.OutSine).SetLoops(2, LoopType.Yoyo);
    Invoke("DelaySetInactive", 1.0f);
}
public void TrioButtonselected()
{
    TButton.transform.DOScale(ScaleTo, .5f).SetEase(Ease.OutSine).SetLoops(2, LoopType.Yoyo);
    Invoke("DelaySetInactive", 1.0f);
}
public void SquadsButtonselected()
{
    SQButton.transform.DOScale(ScaleTo, .5f).SetEase(Ease.OutSine).SetLoops(2, LoopType.Yoyo);
    Invoke("DelaySetInactive", 1.0f);
}
public void DelaySetInactive()
{
    SMScreen.transform.DOScale(new Vector3 (0,0,0), .5f);
}
}
