using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        moveToCursor();
    }

    void moveToCursor()
    {
        //Declared a variable of type Ray to cast a ray.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit data types stores the information such as where ray 
        //has hit, what it has hit, etc.
        RaycastHit hit;
        
        /*In the following segment, we use Unity Physics to cast a ray.
        This function gives us true or false when it hits something.
        So it checks if 'ray' from above has hit anything and stores info in hit.
        Then if hasHit is true, we use NavMesh Agent to move the agent to destination
        where the ray has hit. And that we get through 'hit' and then accessing its point of contact.
        */
        bool hasHit = Physics.Raycast(ray , out hit);
        if(hasHit)
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
    }
}
