using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;
public class DropdownMenuscript : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public GameObject[] Screens;
    // Start is called before the first frame update
    void Start()
    {
        if (dropdown == null)
        {
            dropdown = GetComponent<TMP_Dropdown>();
        }
        dropdown.value = 0;
        DropdownValueChanged(0);
    }
    public void DropdownValueChanged(int index)
    {
        // Deactivate all GameObjects
        foreach (GameObject obj in Screens)
        {
            obj.SetActive(false);
        }
        if(index >= 0 && index < Screens.Length)
        {
            Screens[index].SetActive(true);
        }
    }
}
