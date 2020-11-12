using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneController : MonoBehaviour
{
    public GameObject highScoreDisplay;
    public GameObject MenuDisplay;

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public void showHighScore()
    {
        MenuDisplay.SetActive(false);
        highScoreDisplay.SetActive(true);
    }
    public void hideHighScore()
    {
        MenuDisplay.SetActive(true);
        highScoreDisplay.SetActive(false);
    }
   
}
