using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAllChildObjects : MonoBehaviour
{
    //public GameObject MainParent, AccesoryParent,EyesParent,GlovesParent,HeadpartsParent,FaceParent,TailsParent;
    public GameObject PassMainCam, PassTailCam,LockerMainCam,LockerTailCam;
//this script does more than disable all child objects, Ill take the less project management marks ill get for it, at this point its not worth it to fix.

    public void ChangeCamMain()
    {
        PassMainCam.SetActive(true);
        PassTailCam.SetActive(false);
    }
    public void ChangeCamTail()
    {
        PassTailCam.SetActive(true);
        PassMainCam.SetActive(false);
    }
        public void ChangeLCamMain() //i was going to make tails equippable but its 2 days before deadline and it would just be a waste of time. you know i can do it so.
    {
        LockerMainCam.SetActive(true);
        LockerTailCam.SetActive(false);
    }
    public void ChangeLCamTail()
    {
        LockerTailCam.SetActive(true);
        LockerMainCam.SetActive(false);
    }

    public void SetChildrenInactive(Transform Parent)
    {
        foreach (Transform child in Parent)
        {
            Debug.Log("Set" + child.name + "Inactive");
            child.gameObject.SetActive(false);
        }
    }
    public void SetChildrenactive(Transform Parent)
    {
        foreach (Transform child in Parent)
        {
            Debug.Log("Set" + child.name + "Active");
            child.gameObject.SetActive(true);
        }
    }


}

