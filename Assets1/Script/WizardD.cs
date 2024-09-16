using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WizardD : MonoBehaviour
{
    // Start is called before the first frame update

    static public WizardD player;
    private Vector3 move;
    public float speed;
    private Rigidbody rb;
    private Vector3 jump;
    private Boolean bl;
    private Vector3 lastDirection;
    public GameObject fireBall;
    public Vector3 pVectorForward;


    void Start()
    {
        player = this;
    }

    // Update is called once per frame
    void Update()
    {
        pVectorForward = Vector3.forward;
        Physics.IgnoreLayerCollision(3, 6, true);
        bl = false;
        move = Vector3.zero;

        if(Input.GetKey("w") && !bl)
        {
            
            move += Vector3.forward;

        }

        if (Input.GetKey("s"))
        {
            move += Vector3.back;
        }

        if (Input.GetKey("a"))
        {
            move += Vector3.left;

        }

        if (Input.GetKey("d"))
        {
            move += Vector3.right;
        }

        if (move.magnitude > 0)
        {
            lastDirection = move;
        }

        if(Input.GetKeyDown("f"))
        {
            GameObject ob = Instantiate(fireBall, transform.position, Quaternion.identity);
            
        }

        if (move != Vector3.zero && move.y == 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(move);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 50);
        }

        transform.position += move.normalized * speed * Time.deltaTime;
        

    }


}
