using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    //script will give player a set score per level
    //when the player collides with a obsticle their score will be decreased 
    //as a desierable players will be able to pick up "coins" in order to increase their score

    public int initialScore;
    public int currentScore;
    public int decreaseScoreAmount;
    public int increaseScoreAmount;

    public Text scoreText;

    void Start()
    {
        currentScore = initialScore;
        Debug.Log("current Score = " + currentScore);
    }

    public void IncreaseScore()
    {
        currentScore += increaseScoreAmount;
        Debug.Log("current Score = " + currentScore);
    }
    
    public void LoseScore()
    {
        currentScore -= decreaseScoreAmount;
        Debug.Log("current Score = " + currentScore);
    }

    public void DisplayScore()
    {
        Debug.Log("DisplayScore called");
        scoreText.text = currentScore.ToString();
    }
}
