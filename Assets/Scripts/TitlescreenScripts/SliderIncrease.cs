using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class SliderIncrease : MonoBehaviour
{
    //made with the assistance of AI. Wrote all the code by myself and comments but using ai as reference
    public Slider loadingbar;
    public float mintime = 1f;
    public float maxtime = 10f;
    public TextMeshProUGUI percentageText;
    public GameObject MainMenu, LobbyScreen, LobbyCamera;
    public AudioSource src;
    public AudioClip LobbyMusic;
    void Start()
    {
        loadingbar.onValueChanged.AddListener((v) => //adds a function to record the value of the slider in code so it can be referenced
        {
            percentageText.text = v.ToString("0%"); //Sets text to the value with a % after it
        });
        StartCoroutine(Increaseslidervalue());

    }
    IEnumerator Increaseslidervalue() //IEnumerator doesn't interrupt gameflow though this is for a loadingscreen 
    {

        {
            float randomTime = UnityEngine.Random.Range(mintime, maxtime); //Chooses a random number between the mintime and maxtime floats and assigns it to the float randomTime
            float initialValue = loadingbar.value; //sets initialValue as the value of the slider
            for (float t = 0; t < randomTime; t += Time.deltaTime) //For loop, as long as t is less than the randomTime float then it will keep increasing the value.
            {
                loadingbar.value = Mathf.Lerp(initialValue, loadingbar.maxValue, t / randomTime); //gradually changes slider value
                yield return null; //waits until next frame
            }
            Invoke("OpenLobby", 0.1f);
        }
    }

    public void OpenLobby()
    {
        MainMenu.SetActive(false);
        LobbyScreen.SetActive(true);
        LobbyCamera.SetActive(true);
        src.clip = LobbyMusic;
        src.Play();
    }
}
