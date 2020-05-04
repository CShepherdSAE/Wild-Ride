using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public float forwardSpeed = 10f;
    public float fSpeedUp = 0.005f;
    public float maxFSpeed = 30f;
    public float speed = 1f;
    public Rigidbody rb;
    public Vector3 moveForward;


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        //rb.isKinematic = true; (only needed if useing move position)
    }

    void Update()
    {
        Speedup();
    }

    private void FixedUpdate()
    {
        this.rb.velocity = new Vector3(forwardSpeed, 0, 0);
        //driveforward(moveForward);
    }

    void Speedup()
    {
        if (forwardSpeed <= maxFSpeed)
        {
            forwardSpeed += fSpeedUp;
        }
    }

    //void driveforward(Vector3 direction)
    //{
    //    rb.AddForce(direction * forwardSpeed);
    //}
}
