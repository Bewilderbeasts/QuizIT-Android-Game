using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.CodeDom;
using System.Globalization;


public class SampleScene : MonoBehaviour
{

    public Text scoreDisplayText;

    private SavePosition savePosition;
    

    private int playerScore;
    private int currentRound;
    private int poziom;
    // Start is called before the first frame update
    void Start()
    {
        
        playerScore = PlayerPrefs.GetInt("Score");
        currentRound = PlayerPrefs.GetInt("currentRound");
        poziom = PlayerPrefs.GetInt("Poziom");
        DisplayScore();
        
    }

    public void DisplayScore()
    {

        
        Debug.Log("wynik: " + playerScore.ToString());
        Debug.Log("Runda: " + currentRound.ToString());
        Debug.Log("poziom: " + poziom.ToString());

        scoreDisplayText.text = "Wynik: " + playerScore.ToString();
    }
    
    public void tablica()
    {
        if (currentRound == 0)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            
            Debug.Log("Idź do kolejnej klasy " + currentRound.ToString());
        }
     }
    public void tablica1()
    {
        if (currentRound == 1)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
          
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica2()
    {
        if (currentRound == 2)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica3()
    {
        if (currentRound == 3)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica4()
    {
        if (currentRound == 4)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica5()
    {
        if (currentRound == 5)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica6()
    {
        if (currentRound == 6)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica7()
    {
        if (currentRound == 7)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica8()
    {
        if (currentRound == 8)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica9()
    {
        if (currentRound == 9)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
