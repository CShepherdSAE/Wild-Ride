using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfiniScoreScript : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public Text distanceText;

    //If I want to add pickups in the future
    public float negativeScore = 0f;
    float coinScore = 0f;
    float score = 0f;

    void Update()
    {
        distanceText.text = player.transform.position.x.ToString("0");
    }

    public void AddDistanceToScore()
    {
        score = player.transform.position.x + negativeScore + coinScore;
        scoreText.text = score.ToString("0");
    }
}
