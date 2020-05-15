using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideScript : MonoBehaviour
{

    MoveScript moveScript;
    ScoreScript scoreScript;
    //CarScript carScript;



    [SerializeField]
    bool hitObstical =  false;

    public Animator anim;

    private void Start()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
        moveScript = FindObjectOfType<MoveScript>();
        //carScript = FindObjectOfType<CarScript>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Car" && !hitObstical)
        {
            hitObstical = true;
            moveScript.forwardSpeed = moveScript.forwardSpeed / 2f;
            scoreScript.LoseScore();
            //Debug.Log("speed set in Collide Script");
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
