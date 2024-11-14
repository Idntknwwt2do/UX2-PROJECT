using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IsPassPurchased : MonoBehaviour
{
public PassManager passManager;
public ValueManager valueManager;



public void BuyPass()
{
    if(valueManager.Rhubucks >= passManager.PassCost)
    {
        valueManager.Rhubucks -= passManager.PassCost;
        passManager.PassBought = true;
        Debug.Log("PassBought");
    }
    else if (valueManager.Rhubucks < passManager.PassCost)
    {
        Debug.Log("Insufficient Rhubucks");
    }
}

}
