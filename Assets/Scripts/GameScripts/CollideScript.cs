using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideScript : MonoBehaviour
{

    MoveScript MoveScript;

    public GameObject Car;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        MoveScript.forwardSpeed = 0f;
        Debug.Log("speed set in Collide Script");
    }

}
