using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour
{

    public MoveScript MoveScript;

    public GameObject finishLineText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            MoveScript.forwardSpeed = 0f;
            MoveScript.accelSp1 = 0f;


        }
    }
}
