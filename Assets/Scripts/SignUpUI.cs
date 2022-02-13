using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SignUpUI : MonoBehaviour
{
    public static Action ActionLogIn;
    
    [SerializeField] private TextMeshProUGUI username;
    [SerializeField] private Button[] nextButtons;

    private PlayerData data;
    
    private void Awake()
    {
        data = PersistentSave.Load();
    }

    private void Update()
    {
        // print(username.text);
        
        if (username.text.Length < 5)
        {
            foreach (Button a in nextButtons)
            {
                a.interactable = false;
            }
        }
        else
        {
            foreach (Button a in nextButtons)
            {
                a.interactable = true;
            }
        }
    }

    public void SignUp()
    {
        AppManager.UserName = username.text;
        
        PersistentSave.Save();
        ActionLogIn();
    }

    public void BecomeCreator()
    {
        AppManager.IsCreator = true;

        SignUp();

    }
}
