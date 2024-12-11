using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq.Expressions;
public class Buttonscript : MonoBehaviour
{
  public GameObject loginscreen;
  public GameObject passresetscreen;
  public GameObject Accountcreatescreen;
  public GameObject TermsOfServiceScreen;
  public AudioSource src;
  public AudioClip Screenpopup;
  public void Openlogin()
  {
    loginscreen.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine); //Opens the login panel when button pressed in a smooth anim
    src.clip = Screenpopup; //Sets sound clip to screenpopup
    src.Play(); //Plays sound clip when when the screen opens up
  }
  public void CloseLogin()
  {
    loginscreen.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);

  }
  public void Openpassreset()
  {
    passresetscreen.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine);
    src.clip = Screenpopup;
    src.Play();
  }
  public void Closepassreset()
  {
    passresetscreen.transform.DOScale(new Vector3(0, 0, 0), .5F).SetEase(Ease.OutSine);

  }
  public void OpenAccountCreation()
  {
    Accountcreatescreen.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine);
    src.clip = Screenpopup;
    src.Play();
  }
  public void CloseAccountCreation()
  {
    Accountcreatescreen.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
  }
  public void OpenTOS()
  {
    TermsOfServiceScreen.transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutSine);
    src.clip = Screenpopup;
    src.Play();
  }
  public void CloseTOS()
  {
    TermsOfServiceScreen.transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutSine);
  }
}
