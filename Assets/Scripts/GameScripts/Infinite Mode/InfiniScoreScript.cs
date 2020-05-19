using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfiniScoreScript : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public Text distanceText;

    public float mps;

    public GameObject losePanel;

    //If I want to add pickups in the future
    public float negativeScore = 0f;
    float coinScore = 0f;
    float score = 0f;

    void Update()
    {
        distanceText.text = player.transform.position.x.ToString("0");

        //mps = (player.transform.position.x / Time.realtimeSinceStartup) * 18 / 5;

       // Debug.Log(mps.ToString("0.00") + "km/h");
    }

    public void AddDistanceToScore()
    {
        score = player.transform.position.x + negativeScore + coinScore;
        losePanel.SetActive(true);
        Time.timeScale = 0;
        scoreText.text = score.ToString("0");
    }
}
