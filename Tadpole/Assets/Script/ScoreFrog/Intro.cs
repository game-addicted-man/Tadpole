﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("goGame", 6.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void goGame()
    {
        SceneManager.LoadScene("InfiniteFrog");
    }
}
