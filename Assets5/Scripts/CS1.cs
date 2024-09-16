using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS1 : MonoBehaviour
{
    public float speed = 40;
    private Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello" + gameObject.name);

        tf = gameObject.GetComponent<Transform>();
        Debug.Log(tf.position);
        tf.position = new Vector3(4,5,6);

        Debug.Log(tf.position);
        

       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);

        //tf.position += new Vector3(0, 0, 0.1f);
        tf.Translate(0, 0, speed * Time.deltaTime);
        
    }
}
