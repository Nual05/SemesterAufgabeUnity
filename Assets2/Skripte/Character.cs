using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject parent;
    public GameObject[] child;
    public string childTag;

    public Material myMaterial;
  

    void Start()
    {





        child = new GameObject[parent.transform.childCount];
      
        for (int i = 0; i < child.Length; i++)
        {


            child[i] = parent.transform.GetChild(i).gameObject;
            childTag = child[i].gameObject.tag;

            Debug.Log("Hi " + child[i].transform.name + " " + childTag);

            if (!child[i].gameObject.activeSelf)
            {
                child[i].gameObject.SetActive(true);
               

            }

            
            child[i].GetComponent<Renderer>().material = myMaterial;
            
        }
        
        
      




    }

    // Update is called once per frame
    void Update()
    {
       

       
    }
}
