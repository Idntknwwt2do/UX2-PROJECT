using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class IsPassPurchased : MonoBehaviour
{
    public PassManager passManager;
    public ValueManager valueManager;
    public GameObject PassScreen, BuyScreen;
    public ScreenManager screenManager;
    public int Rhubucks;
    public AudioSource src;
    public AudioClip BuySfx, InsufFundsSfx;



    public void BuyPass()
    {
        if (valueManager.Rhubucks >= 950)
        {
            valueManager.Rhubucks -= 950;
            passManager.PassBought = true;
            Debug.Log("PassBought");
            PassScreen.SetActive(true);
            BuyScreen.SetActive(true);
            Invoke("OpenRhuPassBuyScreen", 0.1f);
            src.clip = BuySfx;
            src.Play();


        }
        else if (valueManager.Rhubucks < -950)
        {
            Debug.Log("Insufficient Rhubucks");
            src.clip = InsufFundsSfx;
            src.Play();
        }
    }
    void OpenRhuPassBuyScreen()
    {
        PassScreen.transform.DOLocalMoveX(0, 1f, true);
    }
    void Start()
    {
        Rhubucks = valueManager.Rhubucks;
        passManager.PassBought = false;

    }
    void Update()
    {

    }

}
