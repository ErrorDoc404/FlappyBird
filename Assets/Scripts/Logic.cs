using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    private int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void add()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
}
