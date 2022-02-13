using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour
{
    public static List<string> Hashes;

    // SET TO TRUE TO PERFORM AUTOLOGIN
    private bool login = true;

    
    
    // This login must be stored on the server with other records of username, pwd pair
    public static Dictionary<string, string> Login;

    public static string UserName;
    public static bool IsCreator;
    
    public static int Coins;

    private void Awake()
    {
        // DontDestroyOnLoad(gameObject);
        
        SignUpUI.ActionLogIn += LogIn;
        
        LogIn();
    }

    private void Update()
    {
        print($"{UserName}, {IsCreator}");
    }

    private void LogIn()
    {
        PlayerData data = PersistentSave.Load();
        
        // TODO: After checking if data is present use the data to auto login
        
        if (data != null && login)
        {
            Login = data.login;


            UserName = data.username;
            IsCreator = data.isCreator;

            Coins = data.coins;
            
            // print("MENU");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            // TODO: GOTO SIGN UP PAGE
        }
    }

    private void OnDisable()
    {
        SignUpUI.ActionLogIn -= LogIn;
    }
}
