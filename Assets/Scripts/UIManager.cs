using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject homePanel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public GameObject coinCounterPanel;
    public Text score;
    public Text highScore1;
    public Text highScore2;
    public Text coinCounter;

    private void Start()
    {
        highScore1.text = "High Score: " + PlayerPrefs.GetInt("highScore");
    }
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void GameStart()
    {
        coinCounterPanel.SetActive(true);
        tapText.SetActive(false);
        homePanel.GetComponent<Animator>().Play("panelUp");
    }

    public void GameOver()
    {
        coinCounterPanel.SetActive(false);
        score.text = PlayerPrefs.GetInt("score").ToString();
        highScore2.text = PlayerPrefs.GetInt("highScore").ToString();
        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    private void Update()
    {
        coinCounter.text = "Coins: " + BallController.instance.coins;
    }
}
