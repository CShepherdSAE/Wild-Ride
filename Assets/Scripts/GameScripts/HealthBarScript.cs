using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{

    public GameObject losePanel;

    public Slider slider;

    //public bool isInfiniteMode;

    CarScript carScript;
    InfiniScoreScript infiniScoreScript;

    private void Start()
    {
        carScript = FindObjectOfType<CarScript>();
        infiniScoreScript = FindObjectOfType<InfiniScoreScript>();
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;

        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;

        if (health <= 0)
        {
            if(carScript.isInfiniteMode == true)
            {
                infiniScoreScript.AddDistanceToScore();
            }
            else
            {
                losePanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
