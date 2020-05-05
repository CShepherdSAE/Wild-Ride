using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public float forwardSpeed = 0f;
    public float fSpeedUp;
    public float maxFSpeed;
    public float speed;
    public float curMoveSpeed;
    public float accelSp1;
    public float accelSp2;

    public Rigidbody rb;

    //public Vector3 moveForward;
    public Vector3 hMovement;

    bool move;

    float multi = 50f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        hMovement = new Vector3(forwardSpeed, 0f, Input.GetAxis("Horizontal") * -1) * Time.deltaTime;
        curMoveSpeed = forwardSpeed * speed * multi;
        Speedup();
        //Debug.Log(Input.GetAxis("Horizontal"));

    }

    private void FixedUpdate()
    {
        //driveforward(moveForward);
        MoveCar(hMovement);
    }



    void MoveCar(Vector3 direction)
    {
        this.rb.velocity = (direction * Time.deltaTime * multi);
        rb.velocity = (direction * curMoveSpeed);
    }

    void Speedup()
    {
        if (forwardSpeed <= maxFSpeed)
        {
            if (forwardSpeed <= maxFSpeed/1.5)
            {
                fSpeedUp = accelSp1;
            }
            else
            {
                fSpeedUp = accelSp2;   
            }

            forwardSpeed += fSpeedUp;
        }
    }

    //old code

    //was in start
    //rb.isKinematic = true; (only needed if useing move position)

    //moved to another script
    //private void OnCollisionStay(Collision collision)
    //{
    //    forwardSpeed = 0f;
    //}

    //from void MoveCar()
    //Debug.Log("move car being called");
    //this.rb.AddForce(new Vector3(forwardSpeed, 0, 0) * Time.deltaTime * multi);
    //rb.AddForce(direction * curMoveSpeed *-1);
    //Debug.Log("force being added");

    //void driveforward(Vector3 direction)
    //{
    //    rb.AddForce(direction * forwardSpeed);
    //}
}
