using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayerPopUp : MonoBehaviour
{
    public GameObject PopupDS, PopupJP, PopupCN, PopupLL;

    public void ShowPopUPDS()
    {
        PopupDS.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine); //Repeating Code
    }
    public void ShowPopUPJP()
    {
        PopupJP.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine);
    }
    public void ShowPopUPCN()
    {
        PopupCN.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine);
    }
    public void ShowPopUPLL()
    {
        PopupLL.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine);

    }
    public void ClosePopUPDS()
    {
        PopupDS.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
    }
    public void ClosePopUPJP()
    {
        PopupJP.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
    }
    public void ClosePopUPCN()
    {
        PopupCN.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
    }
    public void ClosePopUPLL()
    {
        PopupLL.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
    }
}
