﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameOver;
    public AdManager adManager;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        UIManager.instance.GameStart ();
        ScoreManager.instance.StartScore ();
        GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().StartSpawningPlatforms();
    }

    public void GameOver()
    {
        if(gameOver == false)
        {
            float randomNumber = Random.Range(0, 100);
            //adManager.DisplayInterstitialAD();

            if (randomNumber < 34)
            {
                adManager.DisplayInterstitialAD();
                UIManager.instance.GameOver();
                ScoreManager.instance.StopScore();
                gameOver = true;
            }
            else
            {
                UIManager.instance.GameOver();
                ScoreManager.instance.StopScore();
                gameOver = true;
            }
        }
    }
}
