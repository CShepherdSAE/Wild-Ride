using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public float forwardSpeed = 0f;
    public float fSpeedUp;
    public float maxFSpeed;
    public float speed;
    public float sideSpeed;
    public float minSideMove;
    public float sideSpeedMulti = 0.1f;
    public float curMoveSpeed;
    public float spStage;
    public float accelSp1;
    public float accelSp2;

    public Rigidbody rb;

    //public Vector3 moveForward;
    public Vector3 hMovement;

    //bool move;

    float multi = 50f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        //Debug.Log("start happened");
    }

    private void FixedUpdate()
    {
        hMovement = new Vector3(forwardSpeed, 0f, Input.GetAxis("Horizontal") * sideSpeed * -1) * Time.deltaTime;
        curMoveSpeed = forwardSpeed * speed * multi;
        Speedup();
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
        if (!PauseLevelScript.gameIsPaused)
        {
            if (forwardSpeed <= maxFSpeed)
            {
                if (forwardSpeed <= maxFSpeed / spStage)
                {
                    fSpeedUp = accelSp1;
                }
                else
                {
                    fSpeedUp = accelSp2;
                }

                forwardSpeed += fSpeedUp;
            }

            if (forwardSpeed <= minSideMove)
            {
                sideSpeed = 0.5f;
            }
            else
            {
                sideSpeed = forwardSpeed * sideSpeedMulti;
            }
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
