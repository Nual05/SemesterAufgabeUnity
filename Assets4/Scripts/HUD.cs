using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Android;

public class HUD : MonoBehaviour
{

    public TMP_Text scoreText;
    public TMP_Text versuchText;

    public GameMode PlayerGameMode;
    public static int score = 0;
    public static int versuch = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerGameMode.score;
        versuch = PlayerGameMode.versuch;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        versuchText.text = "Versuch: " + versuch;
    }
}
