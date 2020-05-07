using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideScript : MonoBehaviour
{

    public MoveScript MoveScript;

    public GameObject Car;

    public Animator Anim;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        MoveScript.forwardSpeed = 0f;
        Debug.Log("speed set in Collide Script");
        StartCoroutine(PlayAnimation());
        Destroy(gameObject);
    }

    private IEnumerator PlayAnimation()
    {
        yield return new WaitForSeconds(5f);
        Debug.Log("it did the thing");
    }

}
