
using UnityEngine;

public class CS3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent < CS2 >().ShowLabel = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
