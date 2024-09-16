using UnityEngine;

public class CS2 : MonoBehaviour
{
    public bool ShowLabel = false;
    private Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    private void OnGUI()
    {
        if (ShowLabel)
        {
            GUI.Label(new Rect(new Vector2(0.1f, 0.1f), new Vector2(100, 200)),tf.position.ToString());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
