using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JoyStickMovement : MonoBehaviour
{
    public FixedJoystick joystick;
    public float playerspeed;
    private NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.right*joystick.Horizontal + Vector3.forward*joystick.Vertical;
        //rb.AddForce(direction*playerspeed*Time.fixedDeltaTime);
        Movement(direction);
    }

    void Movement(Vector3 directionVector)
    {
        Vector3 motionVector = directionVector*playerspeed*Time.fixedDeltaTime;
        navMeshAgent.Move(motionVector);
        navMeshAgent.SetDestination(transform.position+motionVector);
    }
}
