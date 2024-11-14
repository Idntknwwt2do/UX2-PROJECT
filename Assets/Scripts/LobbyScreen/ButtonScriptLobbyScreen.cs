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
        Invoke("PbuttonRaise", 0f);
    }
   public void PbuttonRaise()
   {
    ActiveButton = PButton; //Sets active button to Pbutton
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true); //Tweens the active button up to -425 on the Y axis only
    src.clip = ButtonClick; //Gets the audio clip ButtonClick which is set in the inspector
    src.Play(); //Plays the selected clip
    //Invoke("LockActiveButton", .25f);
    //Invoke("UnlockActiveButton", 1f);
   }
   public void QbuttonRaise()
   {
    ActiveButton = QButton;
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
    src.clip = ButtonClick;
    src.Play();
    //Invoke("LockActiveButton", .25f);
    //Invoke("UnlockActiveButton", 1f);
   }
   public void RPbuttonraise()
   {
    ActiveButton = RPButton;
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
    src.clip = ButtonClick;
    src.Play();
    //Invoke("LockActiveButton", .25f);
    //Invoke("UnlockActiveButton", 1f);
   }
   public void LbuttonRaise()
   {
    ActiveButton = LButton;
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
    src.clip = ButtonClick;
    src.Play();
    //Invoke("LockActiveButton", .25f);
    //Invoke("UnlockActiveButton", 1f);
   }
   public void Sbuttonraise()
   {
    ActiveButton = SButton;
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
    src.clip = ButtonClick;
    src.Play();
    //Invoke("LockActiveButton", .25f);
    //Invoke("UnlockActiveButton", 1f);
   }
   public void Cbuttonraise()
   {
    ActiveButton = CButton;
    ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
    src.clip = ButtonClick;
    src.Play();
    //Invoke("LockActiveButton", .25f);
    //Invoke("UnlockActiveButton", 1f);
   }
   public void ActiveButtonLower()
   {
    ActiveButton.transform.DOLocalMoveY(-448, .25f, true);
    
   }
   /*public void LockActiveButton()
   {
    ActiveButton.enabled = false;
   }
   public void UnlockActiveButton()
   {
    ActiveButton.enabled = true;
   } */
} 

