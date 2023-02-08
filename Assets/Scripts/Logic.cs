using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    private int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void add(int score)
    {
        playerScore = playerScore + score;
        scoreText.text = playerScore.ToString();
    }
}