using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public TMP_Text scoreText;

    public void addScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();

    }
}
