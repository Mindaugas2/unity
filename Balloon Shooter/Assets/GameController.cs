using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;

    public TMP_Text healthText;
    public int health = 5;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void AddScore(int score)
    {
        this.score += score;
        scoreText.text = "Taškai: " + this.score.ToString();
    }

    public void SubtractHealth()
    {
        health--;
        healthText.text = health.ToString();
    }
}
