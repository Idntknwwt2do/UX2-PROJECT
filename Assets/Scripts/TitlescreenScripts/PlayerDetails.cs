using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class PlayerDetails : MonoBehaviour
{
    private string username;
    private string password;
    public List<TextMeshProUGUI> UsernameTexts, PasswordTexts;
    public Button loginButton;
    private bool PassMatches, UserMatches;
    //private string InputUser,InputPass;
    public GameObject CheckUsernameObj, CheckPasswordObj, ChangeUserPanel, ChangePassPanel, ChangePassField, ChangeUserField;
    void Start()
    {
        loginButton.enabled = false; //sets the bools to be false at the start, the login button is false so the player cant click it straight away.
        PassMatches = false;
        UserMatches = false;
        username = "1234";
        password = "TestPass";

    }


    public void ReadinputUsername(string input)
    {
        username = input; //sets whatever the player inputs into the textfield to be the username variable

    }
    public void ReadInputPassword(string input)
    {
        password = input;//sets whatever the player inputs into the textfield to be the password variable

    }
    public void Loginuser(string InputUser)
    {
        if (InputUser != username) //checks if input matches username
        {
            CheckUsernameObj.SetActive(true);
            Invoke("Usernametextinactive", 1f);
        }
        if (InputUser == username)
        {
            UserMatches = true; //sets bool to true
        }

    }
    public void LoginPass(string InputPass)
    {
        if (InputPass != password) //checks if the Input matches the password
        {
            CheckPasswordObj.SetActive(true); //sets the 'PASSWORD NOT CORRECT' text active
            Invoke("Passwordtextinactive", 1f); //closes the incorrect pass text 
        }
        if (InputPass == password) //checks if the input matches the password
        {
            PassMatches = true; //sets bool to true
        }
    }
    public void CheckPass(string Input)
    {
        if (Input == password)
        {
            ChangePassField.SetActive(true);
        }
        else if (Input != password)
        {
            CloseChangePassPanel();
        }
    }
    public void CheckUser(string Input)
    {
        if (Input == username)
        {
            ChangeUserField.SetActive(true);
        }
        if (Input != username)
        {
            CloseChangeUserPanel();
        }
    }
    void Update()
    {
        if (UserMatches == true && PassMatches == true) //checks if the password and username matches 
        {
            loginButton.enabled = true; //sets the login button to be enabled.
            Debug.Log("Login Button Enabled");
        }
        foreach (var TXT in UsernameTexts)
        {
            TXT.text = username;
        }
        foreach (var TXT in PasswordTexts)
        {
            TXT.text = password;
        }
    }

    private void Usernametextinactive()
    {
        CheckUsernameObj.SetActive(false);
    }
    private void Passwordtextinactive()
    {
        CheckPasswordObj.SetActive(false);
    }
    public void ShowChangeUserPanel()
    {
        ChangeUserPanel.transform.DOScale(new Vector3(1, 1, 1), .5f);
    }
    public void CloseChangeUserPanel()
    {
        ChangeUserPanel.transform.DOScale(new Vector3(0, 0, 0), .5f);
    }
    public void ShowChangePassPanel()
    {
        ChangePassPanel.transform.DOScale(new Vector3(1, 1, 1), .5f);
    }
    public void CloseChangePassPanel()
    {
        ChangePassPanel.transform.DOScale(new Vector3(0, 0, 0), .5f);
    }
}
