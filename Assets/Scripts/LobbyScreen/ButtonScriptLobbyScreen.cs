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
    // Start is called before the first frame update
   public void PbuttonRaise()
   {
    PButton.transform.DOLocalMoveY(-500, .25f, true);
   }
   public void QbuttonRaise()
   {
    QButton.transform.DOLocalMoveY(-500, .25f, true);
   }
   public void RPbuttonraise()
   {
    RPButton.transform.DOLocalMoveY(-500, .25f, true);
   }
   public void LbuttonRaise()
   {
    LButton.transform.DOLocalMoveY(-500, .25f, true);
   }
   public void Sbuttonraise()
   {
    SButton.transform.DOLocalMoveY(-500, .25f, true);
   }
   public void Cbuttonraise()
   {
    CButton.transform.DOLocalMoveY(-500, .25f, true);
   }
}
