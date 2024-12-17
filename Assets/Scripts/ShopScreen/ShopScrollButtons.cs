using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class ShopScrollButtons : MonoBehaviour
{
    //this is my reason for not being on a programming role in the GameProduction2 project
    //public GameObject ActiveScroll1, ActiveScroll2, ActiveScroll3, ActiveScroll4, ActiveScroll5;
    public List<GameObject> ActiveButtons;
    public List<Button> ScrollButtons;
    public Transform Content;


    public void ScrollToPage1()
    {
        if (ActiveButtons[1].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + -1000, .5f, false);

        }
        else if (ActiveButtons[2].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + -2000, .5f, false);

        }
        else if (ActiveButtons[3].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + -3000, .5f, false);

        }
        else if (ActiveButtons[4].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + -4000, .5f, false);

        }
        foreach (var obj in ActiveButtons)
        {
            obj.SetActive(false);
        }
        SetButtonsLocked();
        Invoke("SetButtonsUnlocked", .6f);
        ActiveButtons[0].SetActive(true);

    }
    public void ScrollToPage2()
    {
        if (ActiveButtons[0].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + 1000, .5f, false);

        }
        else if (ActiveButtons[2].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + -1000, .5f, false);
        }
        else if (ActiveButtons[3].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + -2000, .5f, false);

        }
        else if (ActiveButtons[4].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + -3000, .5f, false);

        }

        foreach (var obj in ActiveButtons)
        {
            obj.SetActive(false);
        }
        SetButtonsLocked();
        Invoke("SetButtonsUnlocked", .6f);
        ActiveButtons[1].SetActive(true);



    }
    public void ScrollToPage3()
    {
        if (ActiveButtons[0].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + 2000, .5f, false);
        }
        else if (ActiveButtons[1].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + 1000, .5f, false);
        }
        else if (ActiveButtons[3].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + -1000, .5f, false);
        }
        else if (ActiveButtons[4].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + -2000, .5f, false);
        }
        foreach (var obj in ActiveButtons)
        {
            obj.SetActive(false);
        }
        SetButtonsLocked();
        Invoke("SetButtonsUnlocked", .6f);
        ActiveButtons[2].SetActive(true);
    }
    public void ScrollToPage4()
    {

        if (ActiveButtons[0].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + 3000, .5f, false);
        }
        else if (ActiveButtons[1].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + 2000, .5f, false);
        }
        else if (ActiveButtons[2].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + 1000, .5f, false);
        }
        else if (ActiveButtons[4].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + -1000, .5f, false);
        }
        foreach (var obj in ActiveButtons)
        {
            obj.SetActive(false);
        }
        SetButtonsLocked();
        Invoke("SetButtonsUnlocked", .6f);
        ActiveButtons[3].SetActive(true);
    }
    public void ScrollToPage5()
    {


        if (ActiveButtons[0].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + 4000, .5f, false);
        }
        else if (ActiveButtons[1].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + 3000, .5f, false);
        }
        else if (ActiveButtons[2].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + 2000, .5f, false);
        }
        else if (ActiveButtons[3].activeSelf)
        {
            Content.transform.DOMoveY(Content.position.y + 1000, .5f, false);
        }
        foreach (var obj in ActiveButtons)
        {
            obj.SetActive(false);
        }
        SetButtonsLocked();
        Invoke("SetButtonsUnlocked", .6f);
        ActiveButtons[4].SetActive(true);
    }
    private void SetButtonsLocked()
    {
        foreach (var BTN in ScrollButtons)
        {
            BTN.enabled = false;
        }
    }
    private void SetButtonsUnlocked()
    {
        foreach (var BTN in ScrollButtons)
        {
            BTN.enabled = true;
        }
    }
}
