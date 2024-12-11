using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RhubuckManager : MonoBehaviour
{
    public int RhubuckAmount;
    public ValueManager ValueManager;
    public TextMeshProUGUI RhubuckAmountTxt;
    // Start is called before the first frame update
    void Start()
    {


    }

    public void AmountToIncrease(int amount)
    {
        RhubuckAmount += amount;
    }

    // Update is called once per frame
    public void Update()
    {
        RhubuckAmount = ValueManager.Rhubucks;
        RhubuckAmountTxt.text = RhubuckAmount.ToString();
    }
}
