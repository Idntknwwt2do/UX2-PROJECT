using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FriendsList : MonoBehaviour
{
    public List<GameObject> friendsBTN;
    public string friendinput;
    public TMP_InputField inputUser;
    public Button AddFriendBTN;
    public GameObject UserNotFoundTXT;
    public AudioSource src;
    public AudioClip FriendAdded, UsernotFound;
    void Start()
    {
    }
    public void AddFriend(string input)
    {
        if (inputUser.text == "Cl0oless")
        {
            friendsBTN[0].SetActive(true);
            src.clip = FriendAdded;
            src.Play();
        }
        else if (inputUser.text == "Monovision")
        {
            friendsBTN[1].SetActive(true);
            src.clip = FriendAdded;
            src.Play();

        }
        else if (inputUser.text == "KingMustard")
        {
            friendsBTN[2].SetActive(true);
            src.clip = FriendAdded;
            src.Play();
        }
        else if (inputUser.text == "TTVSweat")
        {
            friendsBTN[3].SetActive(true);
            src.clip = FriendAdded;
            src.Play();
        }
        else
        {
            UserNotFoundTXT.SetActive(true);
            Invoke("inactiveUNFTxt", 2f);
            src.clip = UsernotFound;
            src.Play();
        }
    }
    void inactiveUNFTxt()
    {
        UserNotFoundTXT.SetActive(false);
    }
}
