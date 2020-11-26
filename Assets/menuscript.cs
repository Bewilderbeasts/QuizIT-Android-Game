using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.CodeDom;
using System.Globalization;
using System.Linq;

public class menuscript : MonoBehaviour
{
    

    private DataController dataController;
    private RoundData currentRoundData;
    private QuestionData[] questionPool;


    
    private int currentRound;


    // Start is called before the first frame update
    void Start()
    {
        dataController = FindObjectOfType<DataController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReplayGame()
    {
        dataController.ResetCurrentRound();
        SceneManager.LoadScene("MenuScene");
    }
}
