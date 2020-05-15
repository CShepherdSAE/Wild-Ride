using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAnimationControlScript : MonoBehaviour
{

    public Animator anim;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("LeftArrowDown", true);
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("RightArrowDown", true);
        }
        
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("LeftArrowDown", false);
        }
        
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("RightArrowDown", false);
        }
    }
}
