using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raccoon : MonoBehaviour
{

    static public raccoon PlayerRef;
    Vector3 move;
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRef = this;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {

        move = Vector3.zero; 

        if(Input.GetKey("w"))
        {
            move += Vector3.up;
        }
        if (Input.GetKey("s"))
        {
            move += Vector3.down;
        }
        if (Input.GetKey("a"))
        {
            move += Vector3.left;
        }
        if (Input.GetKey("d"))
        {
            move += Vector3.right;
        }



        transform.position += move * speed * Time.deltaTime;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision != null)
        {
            Destroy(collision.gameObject);
            ScoreDisplay.score++;
        }
    }
}
