﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    private GameObject gameOverText;

    private GameObject runLengthtext;

    private float len = 0;

    private float speed = 0.03f;

    private bool isGameOver = false;

	// Use this for initialization
	void Start ()
    {
        this.gameOverText = GameObject.Find("GameOver");

        this.runLengthtext = GameObject.Find("RunLength");
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(this.isGameOver == false)
        {
            this.len += this.speed;

            this.runLengthtext.GetComponent<Text>().text = "Distance:   " + len.ToString("F2") + "m";

        }

        if(this.isGameOver == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("GameScene");
            }
        }
	}

    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
    }
}
