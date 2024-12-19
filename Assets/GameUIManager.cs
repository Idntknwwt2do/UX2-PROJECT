using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GameUIManager : MonoBehaviour
{
    public List<GameObject> ActiveSlots;
    public GameObject PauseMenu;

    void Update()
    {
        if (PauseMenu.activeSelf == false && Input.GetKeyDown(KeyCode.Alpha1)) //Checks if input is 1 and the pause menu is inactive so the player cant change weapons when paused
        {
            foreach (var obj in ActiveSlots)
            {
                obj.SetActive(false); //Sets all objects in the hotbar inactive
            }
            ActiveSlots[0].SetActive(true); //sets the first object in the list, in this case the first slot to be active.
        }
       else if (PauseMenu.activeSelf == false && Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (var obj in ActiveSlots)
            {
                obj.SetActive(false);
            }
            ActiveSlots[1].SetActive(true);
        }
               else if (PauseMenu.activeSelf == false && Input.GetKeyDown(KeyCode.Alpha3))
        {
            foreach (var obj in ActiveSlots)
            {
                obj.SetActive(false);
            }
            ActiveSlots[2].SetActive(true);
        }
               else if (PauseMenu.activeSelf == false && Input.GetKeyDown(KeyCode.Alpha4))
        {
            foreach (var obj in ActiveSlots)
            {
                obj.SetActive(false);
            }
            ActiveSlots[3].SetActive(true);
        }
        else if (PauseMenu.activeSelf == false  && Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
            PauseMenu.transform.DOScale(new Vector3 (1,1,1), .5f);
        }
        else if (PauseMenu.activeSelf == true && Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.transform.DOScale(new Vector3 (0,0,0), .5f);
            Invoke("SetPauseInactive", .5f);
        }
        
    }
    void SetPauseInactive()
    {
        PauseMenu.SetActive(false);
    }
}
