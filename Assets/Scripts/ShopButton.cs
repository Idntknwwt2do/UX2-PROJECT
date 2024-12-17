using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Purchasing.Extension;

public class ShopButton : MonoBehaviour
{
    //had help from a friend for most of the code, line 12 until 37 was his help (apart from the lack of a list ofc you can tell that was me)
    // you set these in the inspector
  
    public List<GameObject> Objectstoactivate;
    public GameObject PurchaseFailedScreen;
    [SerializeField] private int BucksNeeded;
    public AudioSource src;
    public AudioClip PurchaseSound,PurchaseFailedSound;
    public ValueManager valueManager;

    private void Awake()
    {
        // get the button component on this object
        var button = GetComponent<Button>();
        // when the button is clicked, runs this code
        // it's just like setting it in the inspector
        button.onClick.AddListener (() => //adds listener to button to detect when its pressed
        {
            if (valueManager.Rhubucks >= BucksNeeded)
            {
                valueManager.Rhubucks -= BucksNeeded;
                foreach(var obj in Objectstoactivate)
                {
                    obj.SetActive(true);
                }
                button.enabled = false;
                src.clip = PurchaseSound;
                src.Play();
            }
            else if(valueManager.Rhubucks < BucksNeeded)
            {
                PurchaseFailedScreenOpen();
                src.clip = PurchaseFailedSound;
                src.Play();
                Invoke("PurchaseFailedScreenClose", 4f);
            }
        });
    }
private void PurchaseFailedScreenOpen()
{
    PurchaseFailedScreen.transform.DOScale(new Vector3 (1,1,1), .5f);
}
private void PurchaseFailedScreenClose()
{
    PurchaseFailedScreen.transform.DOScale(new Vector3(0,0,0), .5f);
}


}


