using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{

    public GameObject quitBoxUI;

    bool wantToQuit = false;

    public void LoadLV1()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLV2()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game... ");
        Application.Quit();
    }

    public void QuitPause()
    {
        quitBoxUI.SetActive(true);
        wantToQuit = true;
    }

    public void QuitResume()
    { 
            quitBoxUI.SetActive(false);
            wantToQuit = false;
    }
}
