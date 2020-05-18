using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawnScript : MonoBehaviour
{

    [SerializeField]
    private GameObject newRoad;

    public Transform roadSpawnPos;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Car")
        {
            Instantiate(newRoad, roadSpawnPos.position, Quaternion.identity);
            Debug.Log("newRoad Spawned");
        }
    }
}
