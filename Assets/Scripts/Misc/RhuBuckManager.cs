using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RhuBuckManager : MonoBehaviour
{
    public ValueManager valueManager;
    public int Rhubucks;
    public TextMeshPro RhuBuckTxt;
    public void Start()
    {
        Rhubucks = valueManager.Rhubucks;
    }
    public void Update()
    {
        Rhubucks = valueManager.Rhubucks;
        RhuBuckTxt.text = Rhubucks.ToString("000000");
    }
}
