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




    public void BuyPass()
    {
        if (valueManager.Rhubucks >= passManager.PassCost)
        {
            valueManager.Rhubucks -= passManager.PassCost;
            passManager.PassBought = true;
            Debug.Log("PassBought");
            PassScreen.SetActive(true);
            BuyScreen.SetActive(true);
            Invoke("OpenRhuPassBuyScreen", 0.1f);

        }
        else if (valueManager.Rhubucks < passManager.PassCost)
        {
            Debug.Log("Insufficient Rhubucks");
        }
    }
   void OpenRhuPassBuyScreen()
   {
    PassScreen.transform.DOLocalMoveX(0, 1f, true);
   }

}
