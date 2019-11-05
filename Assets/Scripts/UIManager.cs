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
    public Text score;
    public Text highScore1;
    public Text highScore2;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void GameStart()
    {
        tapText.SetActive(false);
        homePanel.GetComponent<Animator>().Play("panelUp");
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
