using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public GameObject instructionsPanel;

    private void Start()
    {
        mainMenuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        instructionsPanel.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        mainMenuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        instructionsPanel.SetActive(false);
    }

    public void Options()
    {
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void Instructions()
    {
        mainMenuPanel.SetActive(false);
        instructionsPanel.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("Quit Game... ");
        Application.Quit();
    }

}
