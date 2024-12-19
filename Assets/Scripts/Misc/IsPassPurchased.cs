using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class IsPassPurchased : MonoBehaviour
{
    public PassManager passManager;
    public ValueManager valueManager;
    public GameObject PassScreen, BuyScreen;
    public ScreenManager screenManager;
    public int Rhubucks;
    public AudioSource src;
    public AudioClip BuySfx, InsufFundsSfx;
    public List<Button> passtiers;



    public void BuyPass()
    {
        if (valueManager.Rhubucks >= 950) //checks if the player has enough RhuBucks to buy the pass and if they do it does the whole pass buying function
        {
            valueManager.Rhubucks -= 950;
            passManager.PassBought = true;
            Debug.Log("PassBought");
            PassScreen.SetActive(true);
            BuyScreen.SetActive(true);
            Invoke("OpenRhuPassScreen", 0.1f);
            src.clip = BuySfx;
            src.Play();
            foreach (var BTN in passtiers)
            {
                BTN.enabled = true;
            }


        }
        else if (valueManager.Rhubucks < -950) //if the player does not have enough poitns it doesnt give them the pass AND it plays a sound effect to let them know they are poor
        {
            Debug.Log("Insufficient Rhubucks");
            src.clip = InsufFundsSfx;
            src.Play();
        }
    }
    public void OpenRhuPassScreen()
    {
        PassScreen.transform.DOLocalMoveX(0, 1f, true);
    }
    public void ViewRhuPassScreen()
    {
        PassScreen.transform.DOLocalMoveX(0, 1f, true);
        foreach (var BTN in passtiers)
        {
            BTN.enabled = false;
        }
    }
    public void OpenRhuPassBuyScreen()
    {
        BuyScreen.transform.DOLocalMoveX(0, 1f, true);
    }
    public void ClosePassBuyScreen()
    {
        BuyScreen.transform.DOLocalMoveX(2414, 1f, true);
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
