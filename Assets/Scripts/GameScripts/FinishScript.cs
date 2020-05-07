using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    }

    public void LoadLevelSelect()
    {
        Debug.Log("Level Select loading... ");
    }

    public void RestartLevel()
    {
        Debug.Log("Reloading Level... ");
    }

}
