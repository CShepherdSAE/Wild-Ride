using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public GameObject[] obsticlePatterns;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float maxTime = 10f;
    public float minTime = 3.5f;

    private void Start()
    {
        startTimeBtwSpawn = maxTime;
    }

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rnd = Random.Range(0, obsticlePatterns.Length);
            Instantiate(obsticlePatterns[rnd], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }

}
