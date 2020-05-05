using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRoadScript : MonoBehaviour
{

    public GameObject road;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            Destroy(road);
            Debug.Log("road destroyed");
        }
    }

}
