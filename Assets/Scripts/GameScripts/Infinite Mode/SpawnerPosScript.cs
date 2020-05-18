using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPosScript : MonoBehaviour
{

    //public Transform carPos;
    //public Transform spawnerDist;

    public float carVelocity;

    public Rigidbody rb;

    public Vector3 Movement;

    MoveScript moveScript;

    void Start()
    {
        moveScript = FindObjectOfType<MoveScript>();
    }

    void Update()
    {
        carVelocity = moveScript.rb.velocity.x;
    }

    private void FixedUpdate()
    {
        Movement = new Vector3(carVelocity, 0f, 0f);
        MoveSpawner(Movement);
    }

    void MoveSpawner(Vector3 direction)
    {
        this.rb.velocity = (direction);
    }
}
