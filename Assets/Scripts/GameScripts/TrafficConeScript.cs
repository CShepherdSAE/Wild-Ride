using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficConeScript : MonoBehaviour
{

    public float speedDivide;
    public int destroyWaitTime = 1;

    public Animator anim;
    
    [HideInInspector]
    public bool beenHit = false;

    ScoreScript scoreScript;
    MoveScript moveScript;
    CarScript carScript;

    private void Start()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
        moveScript = FindObjectOfType<MoveScript>();
        carScript = FindObjectOfType<CarScript>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            if (!beenHit)
            {
                beenHit = true;
                moveScript.forwardSpeed = moveScript.forwardSpeed / speedDivide;
                scoreScript.LoseLessScore();
                carScript.HitCone();
                StartCoroutine(DestroyCone());
            }
        }
    }

    IEnumerator DestroyCone()
    {
        anim.SetBool("HitCone", true);
        yield return new WaitForSeconds(destroyWaitTime);
        Destroy(gameObject);
    }

}
