using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideScript : MonoBehaviour
{

    MoveScript moveScript;
    ScoreScript scoreScript;

    //public GameObject Car;

    public Animator anim;

    private void Start()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
        moveScript = FindObjectOfType<MoveScript>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            moveScript.forwardSpeed = moveScript.forwardSpeed / 1.5f;
            scoreScript.LoseScore();
            Debug.Log("speed set in Collide Script");
            StartCoroutine(PlayAnimation());
        }
    }

    private IEnumerator PlayAnimation()
    {
        anim.SetBool("Destroy", true);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
