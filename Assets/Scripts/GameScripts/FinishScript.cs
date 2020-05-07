using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{

    public MoveScript MoveScript;

    public GameObject finishLineUI;
    public GameObject healthBarUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            healthBarUI.SetActive(false);
            finishLineUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void LoadMenu()
    {
        Debug.Log("Menu loading... ");
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadLevelSelect()
    {
        Debug.Log("Level Select loading... ");
        SceneManager.LoadScene("LevelSelect");
    }

    public void RestartLevel()
    {
        Debug.Log("Reloading Level... ");
        ////change to use variable
        //SceneManager.LoadScene("GameScene");
    }

}
