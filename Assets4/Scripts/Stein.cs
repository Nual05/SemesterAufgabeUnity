using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stein : MonoBehaviour
{
    
    public GameObject diamante;
    bool bHasDiamante;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(GetRandomDiamante())
            {
                Instantiate(diamante, gameObject.transform.position, Quaternion.identity);
                HUD.score++;
            }
            Destroy(gameObject);
            HUD.versuch--;
        }
    }

    bool GetRandomDiamante()
    {
        int random = Random.Range(0, 2);
        bHasDiamante = random != 0;
        Debug.Log(bHasDiamante);

        return bHasDiamante;
    }

}
