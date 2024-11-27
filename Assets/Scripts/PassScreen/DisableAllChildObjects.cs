using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAllChildObjects : MonoBehaviour
{
public GameObject BodyParent, AccesoryParent,EyesParent,GlovesParent,HeadpartsParent,FaceParent,TailsParent;
public GameObject MainCam, TailCam;
public bool MainCamActive,TailCamActive;
void Start()
{
    MainCamActive = true;
    TailCamActive = false;
}
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
public void Update()
{
    if(MainCam.activeSelf)
    {
        MainCamActive = true;
        TailCamActive = false;
    }
    else if (MainCamActive == false)
    {
        MainCam.SetActive(false);
        TailCam.SetActive(true);
    }
    else if(TailCam.activeSelf)
    {
        TailCamActive = true;
        MainCamActive = false;
    }
    else if(TailCamActive == false)
    {
        TailCam.SetActive(false);
        MainCam.SetActive(true);
        
    }

}
public void SetBodiesInactive(Transform BodyParent)
{
    foreach (Transform child in BodyParent)
    {
        Debug.Log("Set" + child.name + "Inactive");
        child.gameObject.SetActive(false);
    }
}
public void SetAccesoriesInactive(Transform AccesoryParent)
{
    foreach (Transform child in AccesoryParent)
    {
        Debug.Log("Set" + child.name + "Inactive");
        child.gameObject.SetActive(false);
    }
}
public void SetEyesInactive(Transform EyesParent)
{
    foreach (Transform child in EyesParent)
    {
        Debug.Log("Set" + child.name + "Inactive");
        child.gameObject.SetActive(false);
    }
}
public void SetGlovesInactive(Transform GlovesParent)
{
    foreach (Transform child in GlovesParent)
    {
        Debug.Log("Set" + child.name + "Inactive");
        child.gameObject.SetActive(false);
    }
}

public void SetHeadPartsInactive(Transform HeadPartsParent)
{
    foreach (Transform child in HeadPartsParent)
    {
        Debug.Log("Set" + child.name + "Inactive");
        child.gameObject.SetActive(false);
    }
}
public void SetFaceInactive(Transform FaceParent)
{
    foreach (Transform child in FaceParent)
    {
        Debug.Log("Set" + child.name + "Inactive");
        child.gameObject.SetActive(false);
    }
}
public void SetTailsInactive(Transform TailsParent)
{
    foreach (Transform child in TailsParent)
    {
        Debug.Log("Set" + child.name + "Inactive");
        child.gameObject.SetActive(false);
    }
}
}
