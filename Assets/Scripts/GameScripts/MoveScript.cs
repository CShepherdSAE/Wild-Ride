using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public float forwardSpeed = 0f;
    public float fSpeedUp = 0.005f;
    public float maxFSpeed = 30f;
    public float speed = 10f;
    public float curMoveSpeed;

    public Rigidbody rb;

    public Vector3 moveForward;
    public Vector3 hMovement;

    [SerializeField]
    bool move;

    [SerializeField]
    float multi = 50f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        //rb.isKinematic = true; (only needed if useing move position)
    }

    void Update()
    {
        hMovement = new Vector3(0f, 0f, Input.GetAxis("Horizontal")) * Time.deltaTime;
        curMoveSpeed = forwardSpeed * speed * multi;
        Speedup();
        Debug.Log(Input.GetAxis("Horizontal"));

    }

    private void FixedUpdate()
    {
        //driveforward(moveForward);
        MoveCar(hMovement);
    }

    void MoveCar(Vector3 direction)
    {
        //Debug.Log("move car being called");
        this.rb.AddForce(new Vector3(forwardSpeed, 0, 0) * Time.deltaTime * multi);
        rb.AddForce(direction * curMoveSpeed *-1);
        //Debug.Log("force being added");
    }

    void Speedup()
    {
        if (forwardSpeed <= maxFSpeed)
        {
            if (forwardSpeed <= maxFSpeed/1.5)
            {
                fSpeedUp = 0.01f;
            }
            else
            {
                fSpeedUp = 0.0005f;
            }

            forwardSpeed += fSpeedUp;
        }
    }

    //void driveforward(Vector3 direction)
    //{
    //    rb.AddForce(direction * forwardSpeed);
    //}
}
