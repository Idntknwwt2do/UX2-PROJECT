using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAllChildObjects : MonoBehaviour
{
//public GameObject MainParent, AccesoryParent,EyesParent,GlovesParent,HeadpartsParent,FaceParent,TailsParent;
public GameObject MainCam, TailCam;


public void ChangeCamMain()
{
    MainCam.SetActive(true);
    TailCam.SetActive(false);
}
public void ChangeCamTail()
{
    TailCam.SetActive(true);
    MainCam.SetActive(false);
}

public void SetChildrenInactive(Transform Parent)
{
    foreach (Transform child in Parent)
    {
        Debug.Log("Set" + child.name + "Inactive");
        child.gameObject.SetActive(false);
    }
}


}

