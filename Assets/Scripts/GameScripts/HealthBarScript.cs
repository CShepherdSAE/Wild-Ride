using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{

    public GameObject losePanel;

    public Slider slider;

    CollideScript collideScript;
    InfiniScoreScript infiniScoreScript;

    private void Start()
    {
        collideScript = FindObjectOfType<CollideScript>();
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
            if(collideScript.isInfiniteMode == true)
            {
                infiniScoreScript.AddDistanceToScore();
            }
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
