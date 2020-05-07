using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideScript : MonoBehaviour
{

    public MoveScript MoveScript;

    public GameObject Car;

    public Animator anim;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        MoveScript.forwardSpeed = 0f;
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
