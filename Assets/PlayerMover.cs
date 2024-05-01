using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMover : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(joystick.isActiveAndEnabled && joystick.Direction != Vector2.zero)
        {
            Vector3 inputDirection = new Vector3(-joystick.Direction.x , 0 , -joystick.Direction.y);
            Vector3 destination = transform.position + inputDirection;
            navMeshAgent.SetDestination(destination);
        }
    }
}
