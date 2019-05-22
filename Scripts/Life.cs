﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public Text lifeText;
    public Text moneyText;
    public Text wavesText;
    public Text gameOver;
    public Text waveText;
    public static Vector3 gameOverPos = new Vector3();
    public static bool GameIsOver;
    public GameObject gameOverUI;
    private static Transform TEXT_POS;
    
    private void Start()
    {
        GameIsOver = false;
        TEXT_POS = new GameObject().transform;
        TEXT_POS.position = new Vector3(22f, -68f, 0f);
    }

    // Update is called once per frame to display player stats and check if player has lost
    void Update()
    {
        moneyText.text = PlayerStats.Money.ToString();
        wavesText.text = PlayerStats.Waves.ToString();
        lifeText.text = PlayerStats.Health.ToString();
        if (PlayerStats.Health <= 0 && !GameIsOver)
        {
            EndGame();
        }
    }

    //Ends the game and sets up game over screen
    void EndGame ()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);

    }



}
