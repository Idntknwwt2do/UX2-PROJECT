using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayerPopUp : MonoBehaviour
{
    public GameObject Popup1, Popup2, Popup3, Popup4;
    // Start is called before the first frame update
public void showpopup1()
{
    Popup1.transform.DOScale(new Vector3(1,1,1),.5f ).SetEase(Ease.OutSine);
}
}
