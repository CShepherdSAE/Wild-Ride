using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointScript : MonoBehaviour
{

    public GameObject obsticle;

    void Start()
    {
        Instantiate(obsticle, transform.position, Quaternion.identity);
    }
}
