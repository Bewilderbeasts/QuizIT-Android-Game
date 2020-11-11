using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SampleScene : MonoBehaviour
{

    public Text scoreDisplayText;

    private int playerScore;
    // Start is called before the first frame update
    void Start()
    {
        
        playerScore = 10;
        DisplayScore();
    }

    public void DisplayScore()
    {
        scoreDisplayText.text = "Wynik: " + playerScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
