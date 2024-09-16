using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.5f;
    private bool bl = true;

    public float health = 100.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreLayerCollision(3,7);
        Vector3 playerdirection = WizardD.player.transform.position;
        Vector3 direction = playerdirection - transform.position;
        if(bl)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }

        //////////////////////////////////////////////////////////////////////////////////////
        Vector3 a = Vector3.Normalize(transform.position-WizardD.player.transform.position);
        float d = Vector3.Dot(WizardD.player.pVectorForward, a);
        
        Debug.Log(WizardD.player.transform.rotation);
        //////////////////////////////////////////////////////////////////////////////////////

        if (Fireball.fireballGameObject && (transform.position - Fireball.fireballGameObject.transform.position).magnitude < 1)
        {
            transform.position += new Vector3(0.0f, 0.0f, 2.0f );
        }
            
        
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Its work");
        bl = false;
    }

    private void OnMouseUp()
    {
        bl = true;
    }

    public void TakeDamage(float damage)
    {
        Debug.Log(health);
        if(damage > 0 )
        {
            health -= damage;
        }
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }


}
