﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class overScore : MonoBehaviour
{
    public float finalScore;
    public Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        finalScore = GameObject.Find("Tadpole").GetComponent<TadpoleAction>().finalScore;
        scoreText.text = "Score : " + finalScore.ToString();

    }
}