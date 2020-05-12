using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{

    public int maxHealth = 20;
    public int currentHealth;

    public int healValue = 1;
    public int obsticleDamageValue = 2;
    public int wallDamageValue = 1;

    public HealthBarScript healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obsticle")
        {
            TakeDamage(obsticleDamageValue);
            Debug.Log("hit obsticle");
        }
        else if(collision.gameObject.tag == "Wall")
        {
            TakeDamage(wallDamageValue);
            Debug.Log("hit wall");
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        Debug.Log("Current health = " + currentHealth);
    }

    public void HealDamage(int heal)
    {  
        if(currentHealth < maxHealth)
        {
            Debug.Log("heal if statment entered");

            currentHealth += heal;

            healthBar.SetHealth(currentHealth);

            Debug.Log("Current health = " + currentHealth);
        }
    }
}
