using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseLevelScript : MonoBehaviour
{

    public static bool gameIsPaused = false;
    public static bool wantToQuit = false;

    public GameObject pauseMenuUI;

    public GameObject quitBoxUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (wantToQuit)
            {
                QuitResume();
            }
            else
            {
                QuitPause();
            }
        }
    }

    //pause UI
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void LoadMenu()
    {
        Debug.Log("Menu loading... ");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); 
        gameIsPaused = false;
    }

    public void RestartLevel()
    {
        Debug.Log("Reloading Level... ");
        Time.timeScale = 1f;
        //change to use variable
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log(Time.timeScale);
        gameIsPaused = false;
    }

    public void QuitFromPause()
    {
        quitBoxUI.SetActive(true);
        pauseMenuUI.SetActive(false);
    } 

    //Both pause & quit
    public void QuitGame()
    {
        Debug.Log("Quit Game... ");
        Application.Quit();
    }

    //quit UI

    //pauseing the game by directly pressing the escape key
    public void QuitPause()
    {
        quitBoxUI.SetActive(true);
        Time.timeScale = 0f;
        wantToQuit = true;
    }

    //resume game from quit screen, if player selects no
    public void QuitResume()
    {
        if (gameIsPaused)
        {
            quitBoxUI.SetActive(false);
            pauseMenuUI.SetActive(true);
        }
        else
        {
            quitBoxUI.SetActive(false);
            Time.timeScale = 1f;
            wantToQuit = false;
        }
    }

}
