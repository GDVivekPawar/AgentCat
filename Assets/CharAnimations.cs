using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimations : MonoBehaviour
{
    // public Transform parent;
    private Animator playeranim;
    bool forwardRifleWalk;
    bool fire;
    
    // Start is called before the first frame update
    void Start()
    {
        playeranim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // parent.position = transform.position + new Vector3(1.126871f,2.020662f,-0.79598f);

        if (Input.GetMouseButtonDown(0))
        {
            fire = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            fire = false;
        }

        if (fire)
        {
            playeranim.SetBool("Fire", true);
        }

        else
        {
            playeranim.SetBool("Fire", false);
        }

        if (Input.GetKeyUp("w"))
        {
            forwardRifleWalk = false;
        }

        if (Input.GetKeyDown("w"))
        {
            forwardRifleWalk = true;
        }

        if (forwardRifleWalk)
        {
            playeranim.SetBool("Walk", true);
        }

        else
        {
            playeranim.SetBool("Walk", false);
        }

    }
}
