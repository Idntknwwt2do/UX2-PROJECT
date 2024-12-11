using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class ButtonScriptLobbyScreen : MonoBehaviour
{
    public GameObject PButton, QButton, RPButton, LButton, SButton, CButton;
    public Button[] PlButton, QuButton, RPaButton, LoButton, ShButton, CaButton;
    private GameObject ActiveButton;
    //private Button ButtonActive;
    public AudioSource src;
    public AudioClip ButtonClick;
    //private float ButtonCooldown;

    void Start()
    {
        Invoke("PbuttonRaise", 0f);
        // ButtonCooldown = 0f;
        // PlButton = PButton.GetComponent<Button>();

    }
    public void PbuttonRaise()
    {
        ActiveButton = PButton; //Sets active button to Pbutton
        ActiveButton.transform.DOLocalMoveY(-425, .25f, true); //Tweens the active button up to -425 on the Y axis only
        src.clip = ButtonClick; //Gets the audio clip ButtonClick which is set in the inspector
        src.Play(); //Plays the selected clip
    }
    public void QbuttonRaise()
    {
        ActiveButton = QButton;
        ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
        src.clip = ButtonClick;
        src.Play();
        //Invoke("LockActButton", 0f);
    }
    public void RPbuttonraise()
    {
        ActiveButton = RPButton;
        ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
        src.clip = ButtonClick;
        src.Play();
        //Invoke("LockActButton", 0f);
    }
    public void LbuttonRaise()
    {
        ActiveButton = LButton;
        ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
        src.clip = ButtonClick;
        src.Play();
        //Invoke("LockActButton", 0f);
    }
    public void Sbuttonraise()
    {
        ActiveButton = SButton;
        ActiveButton.transform.DOLocalMoveY(-425, .25f, true);
        src.clip = ButtonClick;
        src.Play();
        //Invoke("LockActButton", 0f);
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
    /*private void LockActButton()
    {
        if (ButtonCooldown > 0)
        {
            Debug.Log(ActiveButton + " Is unlocked");
            //ActiveButton.enabled = false;
        }
        else if (ButtonCooldown == 0)
        {
            Debug.Log(ActiveButton + " Is locked");
            ButtonCooldown = 1f;
           //ActiveButton.enabled = true;
        }
    }*/
}

