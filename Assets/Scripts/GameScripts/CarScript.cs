using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{

    public int maxHealth = 20;
    public int currentHealth;

    public int smokeAppear;

    public int healValue = 1;
    public int obsticleDamageValue = 2;
    public int wallDamageValue = 1;

    public GameObject smoke;

    bool smokeActive = false;

    HealthBarScript healthBarScript;
    //TrafficConeScript trafficConeScript;

    void Start()
    {
        healthBarScript = FindObjectOfType<HealthBarScript>();
        currentHealth = maxHealth;
        healthBarScript.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obsticle")
        {
            TakeDamage(obsticleDamageValue);
            Debug.Log("hit obsticle");
        }
        else if (collision.gameObject.tag == "Wall")
        {
            TakeDamage(wallDamageValue);
            Debug.Log("hit wall");
        }
    }

    public void HitCone()
    {
        TakeDamage(wallDamageValue);
        Debug.Log("hit Cone");
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBarScript.SetHealth(currentHealth);

        Debug.Log("Current health = " + currentHealth);

        if(currentHealth <= maxHealth / smokeAppear && smokeActive == false)
        {
            smoke.SetActive(true);
            smokeActive = true;
        }
    }

    public void HealDamage(int heal)
    {  
        if(currentHealth < maxHealth)
        {
            Debug.Log("heal if statment entered");

            currentHealth += heal;

            healthBarScript.SetHealth(currentHealth);

            Debug.Log("Current health = " + currentHealth);
        }

        if (currentHealth > maxHealth / smokeAppear && smokeActive == true)
        {
            smoke.SetActive(false);
            smokeActive = false;
        }
    }
}
