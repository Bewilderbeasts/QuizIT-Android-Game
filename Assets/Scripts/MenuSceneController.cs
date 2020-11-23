using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneController : MonoBehaviour
{
    public GameObject highScoreDisplay;
    public GameObject MenuDisplay;
    
    public float x, y, z;

    private DataController dataController;
    public void StartGame()
    {
        dataController = FindObjectOfType<DataController>();
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("ScoreMax", 0);
        PlayerPrefs.SetInt("Poziom", 0);
        dataController.ResetCurrentRound();
        resetPosition();
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
    public void resetPosition()
    {
        PlayerPrefs.SetFloat("x", 7.863055F);
        PlayerPrefs.SetFloat("y", -1.625F);
        PlayerPrefs.SetFloat("z", -70.88615F);
    }
}
