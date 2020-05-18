using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGroundScript : MonoBehaviour
{
    public GameObject ground;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            Destroy(ground);
            Debug.Log("Ground destroyed");
        }
    }
}