using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int score = 0;
    public Text scoreText;

    private void Awake()
    {
        instance = this;
    }

    public void incrementScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
    public void decreaseScore()
    {
        score--;
        scoreText.text = "Score: " + score;
    }
}
