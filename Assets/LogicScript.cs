using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public static LogicScript instance;
    public int highScoreValue;
    public Text highScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool isAlive = true;

    public void addScore(int val)
    {
        playerScore += val;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isAlive = true;

    }

    public void saveHighScore()
    {
        highScoreValue = PlayerPrefs.GetInt("HighScore");
        if (playerScore > highScoreValue)
        {
            highScoreValue = playerScore;
            PlayerPrefs.SetInt("HighScore", highScoreValue);
            PlayerPrefs.Save();
        }
        highScore.text = highScoreValue.ToString();

    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        isAlive = false;
        Time.timeScale = 0;
        saveHighScore();

    }

    public void BacktoMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}
