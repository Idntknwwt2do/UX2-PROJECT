using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ButtonScriptLobbyScreen : MonoBehaviour
{
    public GameObject PButton;
    public GameObject QButton;
    public GameObject RPButton;
    public GameObject LButton;  
    public GameObject SButton;
    public GameObject CButton;
    private GameObject ActiveButton;
    // Start is called before the first frame update
   public void PbuttonRaise()
   {
    ActiveButton = PButton;
    ActiveButton.transform.DOLocalMoveY(-500, .25f, true);
   }
   public void QbuttonRaise()
   {
    QButton.transform.DOLocalMoveY(-500, .25f, true);
    PButton.transform.DOLocalMoveY(-522, .25f, true);
    RPButton.transform.DOLocalMoveY(-522, .25f, true);
    LButton.transform.DOLocalMoveY(-522, .25f, true);
    SButton.transform.DOLocalMoveY(-522, .25f, true);
    CButton.transform.DOLocalMoveY(-522, .25f, true);
   }
   public void RPbuttonraise()
   {
    RPButton.transform.DOLocalMoveY(-500, .25f, true);
    QButton.transform.DOLocalMoveY(-522, .25f, true);
    PButton.transform.DOLocalMoveY(-522, .25f, true);
    LButton.transform.DOLocalMoveY(-522, .25f, true);
    SButton.transform.DOLocalMoveY(-522, .25f, true);
    CButton.transform.DOLocalMoveY(-522, .25f, true);
   }
   public void LbuttonRaise()
   {
    LButton.transform.DOLocalMoveY(-500, .25f, true);
    QButton.transform.DOLocalMoveY(-522, .25f, true);
    RPButton.transform.DOLocalMoveY(-522, .25f, true);
    PButton.transform.DOLocalMoveY(-522, .25f, true);
    SButton.transform.DOLocalMoveY(-522, .25f, true);
    CButton.transform.DOLocalMoveY(-522, .25f, true);
   }
   public void Sbuttonraise()
   {
    SButton.transform.DOLocalMoveY(-500, .25f, true);
    QButton.transform.DOLocalMoveY(-522, .25f, true);
    RPButton.transform.DOLocalMoveY(-522, .25f, true);
    LButton.transform.DOLocalMoveY(-522, .25f, true);
    PButton.transform.DOLocalMoveY(-522, .25f, true);
    CButton.transform.DOLocalMoveY(-522, .25f, true);
   }
   public void Cbuttonraise()
   {
    CButton.transform.DOLocalMoveY(-500, .25f, true);
    QButton.transform.DOLocalMoveY(-522, .25f, true);
    RPButton.transform.DOLocalMoveY(-522, .25f, true);
    LButton.transform.DOLocalMoveY(-522, .25f, true);
    SButton.transform.DOLocalMoveY(-522, .25f, true);
    PButton.transform.DOLocalMoveY(-522, .25f, true);
   }
}
