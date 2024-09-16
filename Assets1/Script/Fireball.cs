using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    public float speedBall;
    public float damage = 20;
    static public Fireball fireballGameObject;

    
    // Start is called before the first frame update
    void Start()
    {
        fireballGameObject = this;
        Destroy(gameObject, 3);
        speedBall = 5;
        transform.eulerAngles = WizardD.player.transform.eulerAngles;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 10; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().TakeDamage(damage);
        }
    }


}
