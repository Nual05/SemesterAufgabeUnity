using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject Fruit1;
    public GameObject Fruit2;
    public GameObject Fruit3;
    public float time = 0.0f;

    private GameObject randomGameobject;
    // Update is called once per frame

    void Update()
    {
        int number = Random.Range(1, 4);
        switch (number)
        {
            case 1:
                randomGameobject = Fruit1;
                break;
            case 2:
                randomGameobject = Fruit2;
                break;
            case 3:
                randomGameobject = Fruit3;
                break;

        }

        float randomX = Random.Range(-8.0f, 8.0f);
        float randomY = Random.Range(-4.0f, 4.0f);
        time -= Time.deltaTime;

        if(time <= 0)
        {
            if(randomGameobject != null)
                Instantiate(randomGameobject, new Vector3(randomX, randomY, 0.0f) , Quaternion.identity);
            time = Random.Range(3,5);
        }
    }
}
