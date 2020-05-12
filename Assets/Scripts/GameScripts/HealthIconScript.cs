using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIconScript : MonoBehaviour
{

    CarScript carScript;

    void Start()
    {
        carScript = FindObjectOfType<CarScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            carScript.HealDamage(carScript.healValue);
            Destroy(gameObject);
        }
    }
}
