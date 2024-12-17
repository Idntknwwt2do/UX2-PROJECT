using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CareerScreen : MonoBehaviour
{
    [SerializeField] private List<GameObject> Screens;

    public void ChangeToWins()
    {
        foreach (var SCR in Screens)
        {
            SCR.SetActive(false);
        }
        Screens[0].SetActive(true);
    }
    public void ChangeToT10()
    {
        foreach (var SCR in Screens)
        {
            SCR.SetActive(false);
        }
        Screens[1].SetActive(true);
    }
    public void ChangeToT25()
    {
        foreach (var SCR in Screens)
        {
            SCR.SetActive(false);
        }
        Screens[2].SetActive(true);
    }
    public void ChangeToElims()
    {
        foreach (var SCR in Screens)
        {
            SCR.SetActive(false); //sets everything in the list inactive
        }
        Screens[3].SetActive(true); //sets the 4th object in the list active
    }
}
