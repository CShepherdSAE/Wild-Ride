using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnScript : MonoBehaviour
{

    [SerializeField]
    private GameObject newGround;

    public Transform groundSpawnPos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            Instantiate(newGround, groundSpawnPos.position, Quaternion.identity);
            Debug.Log("newGround Spawned");
        }
    }
}
