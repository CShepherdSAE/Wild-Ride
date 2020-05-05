using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{

    public MoveScript MoveScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            MoveScript.forwardSpeed = 0f;
            MoveScript.accelSp1 = 0f;
        }
    }
}
