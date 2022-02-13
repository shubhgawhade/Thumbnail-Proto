using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PostDisplay : MonoBehaviour
{
    public Post post;

    [SerializeField] private TextMeshProUGUI username;
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI description;
    
    public void Start()
    {
        Post a = GetComponent<Post>();
        username.text = a.Username;
        image.sprite = a.Image;
        description.text = a.Description;
    }
}
