﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{

    public MoveScript MoveScript;

    public GameObject finishLineUI;
    public GameObject healthBarUI;

    public ScoreScript scoreScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            healthBarUI.SetActive(false);
            finishLineUI.SetActive(true);
            Time.timeScale = 0f;
            scoreScript.DisplayScore();
        }
    }

    public void LoadMenu()
    {
        //Debug.Log("Menu loading... ");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadLevelSelect()
    {
        //Debug.Log("Level Select loading... ");
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelSelect");
        PauseLevelScript.gameIsPaused = false;
    }

    public void RestartLevel()
    {
        //Debug.Log("Reloading Level... ");
        Time.timeScale = 1f;
        //change to use variable
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PauseLevelScript.gameIsPaused = false;
    }

}
