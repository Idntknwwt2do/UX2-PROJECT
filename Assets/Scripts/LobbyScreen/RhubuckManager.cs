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
        RhubuckAmount = ValueManager.Rhubucks;
        
    }

    // Update is called once per frame
    void Update()
    {
        RhubuckAmountTxt.text = RhubuckAmount.ToString();
    }
}
