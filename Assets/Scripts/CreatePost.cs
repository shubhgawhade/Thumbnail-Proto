using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreatePost : MonoBehaviour
{
    [SerializeField] private GameObject postPrefab;
    
    [SerializeField] private Sprite postImage;
    [SerializeField] private TextMeshProUGUI postDescription;

    [SerializeField] private GameObject scrollable;

    private Post newPost;
    
    private void Start()
    {
        HomePageUI.Post += PostImage;
    }

    private void PostImage()
    {
        GameObject a = Instantiate(postPrefab, scrollable.transform.position, Quaternion.identity);
        a.transform.parent = scrollable.transform;
        newPost = a.AddComponent<Post>();
        
        newPost.hash = GenerateHash();
        // AppManager.Hashes.Add(newPost.hash);
        
        newPost.Username = AppManager.UserName;
        // newPost.Image = postImage;
        newPost.Description = postDescription.text;
        newPost.Rating = 0;
        print($"{newPost.Username}, {newPost.Description}");
        
    }

    private string GenerateHash()
    {
        var bytes = new byte[16];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(bytes);
        }
        string hash1 = BitConverter.ToString(bytes);

        print(hash1);
        
        return hash1;
    }

    private void OnDisable()
    {
        HomePageUI.Post -= PostImage;
    }
}
