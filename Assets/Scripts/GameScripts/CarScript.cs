﻿using System.Collections;
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
    //public GameObject explosion;

    bool smokeActive = false;

    HealthBarScript healthBarScript;
    //TrafficConeScript trafficConeScript;

    [Header("Camera statistics")]

    [Tooltip("The minimum FOV for the camera at the lowest velocity")]
    public float minFOV = 60f;
    [Tooltip("The maximum FOV for the camera at the lowest velocity")]
    public float maxFOV = 90f;
    [Tooltip("The minimum velocity the car must be going for FOV to begin increasing")]
    public float fovVelocityStart = 10;
    [Tooltip("The rate the FOV wil increase by. (the higher the number, the faster the FOV will increase")]
    public float fovIncreaseVal; //0.0625
    public float fovDecreaseVal;

    //[SerializeField]
    //private bool allowDecFurther;
    //[SerializeField]
    //private bool allowIncBack;

    MoveScript moveScript;
    public Camera cam;

    void Start()
    {
        healthBarScript = FindObjectOfType<HealthBarScript>();
        currentHealth = maxHealth;
        healthBarScript.SetMaxHealth(maxHealth);
        moveScript = GetComponent<MoveScript>();
    }

    private void FixedUpdate()
    {
        UpdateFOV();
    }

    void UpdateFOV()
    {
        // Increase the camera's FOV when the car is going fast enough AND when the fov is still lower then the max FOV
        if (moveScript.rb.velocity.x > fovVelocityStart && cam.fieldOfView <= maxFOV)
        {
            cam.fieldOfView += fovIncreaseVal;
        }

        // If the car's vecocity is greater then the minimum start point AND the camera's FOV is larger then the max FOV, stop
        if (moveScript.rb.velocity.x > fovVelocityStart && cam.fieldOfView >= maxFOV)
        {
            return;
        }

        // If the car's velocity is smaller then the minimum velocity required for FOV increase AND the fov is larger then the min FOV, reduce the FOV
        if (moveScript.rb.velocity.x <= fovVelocityStart && cam.fieldOfView > minFOV)
        {
            cam.fieldOfView -= fovDecreaseVal;
        }
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


//[Header("Camera statistics")]

//[Tooltip("The minimum FOV for the camera at the lowest velocity")]
//public float minFOV = 60f;
//[Tooltip("The maximum FOV for the camera at the lowest velocity")]
//public float maxFOV = 90f;
//[Tooltip("The minimum velocity the car must be going for FOV to begin increasing")]
//public float fovVelocityStart = 10;
//[Tooltip("The rate the FOV wil increase by. (the higher the number, the faster the FOV will increase")]
//public float fovIncreaseVal;
//public float fovDecreaseVal;
////[Tooltip("The minimum FOV for the camera at the rubber band point")]
////public float minFBFOV = 45f;
////[Tooltip("The FOV Decrease amount when the car hits something (RB = Rubber Band)")]
////public float fovDecreaseRBVal;
////[Tooltip("The FOV Increase amount when car returns back to minFOV after hitting something")]
////public float fovIncreaseRBVal;

//[SerializeField]
//private bool allowDecFurther;
//[SerializeField]
//private bool allowIncBack;
////TrafficConeScript trafficConeScript;

//MoveScript moveScript;
//public Camera cam;

//void Start()
//{
//    healthBarScript = FindObjectOfType<HealthBarScript>();
//    currentHealth = maxHealth;
//    healthBarScript.SetMaxHealth(maxHealth);
//    moveScript = GetComponent<MoveScript>();
//}

//private void FixedUpdate()
//{
//    UpdateFOV();
//}

//void UpdateFOV()
//{
//    // Increase the camera's FOV when the car is going fast enough AND when the fov is still lower then the max FOV
//    if (moveScript.rb.velocity.x > fovVelocityStart && cam.fieldOfView <= maxFOV)
//    {
//        cam.fieldOfView += fovIncreaseVal;
//    }

//    // If the car's vecocity is greater then the minimum start point AND the camera's FOV is larger then the max FOV, stop
//    if (moveScript.rb.velocity.x > fovVelocityStart && cam.fieldOfView >= maxFOV)
//    {
//        return;
//    }

//    // If the car's velocity is smaller then the minimum velocity required for FOV increase AND the fov is larger then the min FOV, reduce the FOV
//    if (moveScript.rb.velocity.x <= fovVelocityStart && cam.fieldOfView > minFOV)
//    {
//        cam.fieldOfView -= fovDecreaseVal;
//    }
//}