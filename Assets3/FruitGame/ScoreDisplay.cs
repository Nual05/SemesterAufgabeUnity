using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{

    static public int score = 0;
    public TMP_Text tMP_Text;

    void Update()
    {
        tMP_Text.text = "Score: " + score;
    }

}
