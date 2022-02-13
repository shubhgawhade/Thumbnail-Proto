using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePageUI : MonoBehaviour
{
    public static Action Post;
    
    public void CreatePost()
    {
        Post();
        // SceneManager.LoadScene("CreatePost");
    }
}
