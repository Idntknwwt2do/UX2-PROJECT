using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class ButtonScriptLobbyScreen : MonoBehaviour
{
    public GameObject PButton,QButton,RPButton,LButton,SButton,CButton;

    private GameObject ActiveButton;
    public AudioSource src;
    public AudioClip ButtonClick;

    void Start()
    {
        ActiveButton = PButton; 
    }
   public void PbuttonRaise()
   {
    ActiveButton = PButton;
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
    src.clip = ButtonClick;
    src.Play();
   }
   public void QbuttonRaise()
   {
    ActiveButton = QButton;
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
    src.clip = ButtonClick;
    src.Play();
   }
   public void RPbuttonraise()
   {
    ActiveButton = RPButton;
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
    src.clip = ButtonClick;
    src.Play();
   }
   public void LbuttonRaise()
   {
    ActiveButton = LButton;
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
    src.clip = ButtonClick;
    src.Play();
   }
   public void Sbuttonraise()
   {
    ActiveButton = SButton;
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
    src.clip = ButtonClick;
    src.Play();
   }
   public void Cbuttonraise()
   {
    ActiveButton = CButton;
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
    src.clip = ButtonClick;
    src.Play();
   }
   public void ActiveButtonLower()
   {
    ActiveButton.transform.DOLocalMoveY(-448, .25f, true);
    
   }
}
