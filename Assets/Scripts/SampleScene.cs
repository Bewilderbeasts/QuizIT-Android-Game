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

    private bool showText = false;
    private float timeText;
    private int playerScore;
    private int currentRound;
    private int currentRoom;
    private int poziom;
    // Start is called before the first frame update
    void Start()
    {
        
        playerScore = PlayerPrefs.GetInt("Score");
        currentRound = PlayerPrefs.GetInt("currentRound");
        poziom = PlayerPrefs.GetInt("Poziom");
        currentRoom = currentRound + 1;
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
            timeText = 5;
            showText = true;
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
            timeText = 5;
            showText = true;
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
            timeText = 5;
            showText = true;
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
            timeText = 5;
            showText = true;
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
            timeText = 5;
            showText = true;
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
            timeText = 5;
            showText = true;
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
            timeText = 5;
            showText = true;
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
            timeText = 5;
            showText = true;
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
            timeText = 5;
            showText = true;
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
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica10()
    {
        if (currentRound == 10)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica11()
    {
        if (currentRound == 11)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica12()
    {
        if (currentRound == 12)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica13()
    {
        if (currentRound == 13)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica14()
    {
        if (currentRound == 14)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica15()
    {
        if (currentRound == 15)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica16()
    {
        if (currentRound == 16)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica17()
    {
        if (currentRound == 17)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica18()
    {
        if (currentRound == 18)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica19()
    {
        if (currentRound == 19)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica20()
    {
        if (currentRound == 20)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica21()
    {
        if (currentRound == 21)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica22()
    {
        if (currentRound == 22)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    public void tablica23()
    {
        if (currentRound == 23)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            timeText = 5;
            showText = true;
            Debug.Log("Idź do innej sali: " + currentRound.ToString());
        }
    }
    void OnGUI()
    {
        var centeredStyle = GUI.skin.GetStyle("Label");
        centeredStyle.alignment = TextAnchor.UpperCenter;
        centeredStyle.fontSize = 30;
        if (showText)
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 250, 125), "W tej sali już byłeś. Idź do sali:" + currentRoom.ToString(), centeredStyle);
    }
    // Update is called once per frame
    void Update()
    {
        if (showText)
        {
            timeText -= Time.deltaTime;
            

            if (timeText <= 0f)
            {
                showText=false;
            }

        }
    }
}
