using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideScript : MonoBehaviour
{

    public MoveScript moveScript;
    public ScoreScript scoreScript;

    public GameObject Car;

    public Animator anim;

    private void OnCollisionEnter(Collision collision)
    {
        moveScript.forwardSpeed = 0f;
        scoreScript.LoseScore();
        Debug.Log("speed set in Collide Script");
        StartCoroutine(PlayAnimation());
    }

    private IEnumerator PlayAnimation()
    {
        anim.SetBool("Destroy", true);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
