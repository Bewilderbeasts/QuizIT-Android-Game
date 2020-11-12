using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.CodeDom;
using System.Globalization;

namespace Quiz.Scoreboards
{
    public class GameController : MonoBehaviour
    {


        public Text questionDisplayText;
        public Text scoreDisplayText;
        public Text timeRemainingDisplayText;
        public SimpleObjectPool answerButtonObjectPool;
        public Transform answerButtonParent;
        public GameObject questionDisplay;
        public GameObject roundEndDisplay;
        public GameObject gameOverDisplay;
        public GameObject nextRoundDisplay;
        public GameObject namePlayer;
        public GameObject inputNameDisplay;
        public GameObject inputFieldDisplay;

        private DataController dataController;
        private RoundData currentRoundData;
        private QuestionData[] questionPool;

        public Scoreboard scoreboard;

        private bool isRoundActive;
        private float timeRemaining;
        private int questionIndex;
        private int playerScore;
        private int playerMaxScore;
        private int wynik;
        public string imie;
        
        private List<GameObject> answerButtonGameObjects = new List<GameObject>();

        // Use this for initialization
        void Start()
        {
            dataController = FindObjectOfType<DataController>();
            SetUpRound();
            playerScore = 0;
            playerMaxScore = 0;
        }

        public void SetUpRound()
        {
            currentRoundData = dataController.GetCurrentRoundData();
            questionPool = currentRoundData.questions;
            timeRemaining = currentRoundData.timeLimitInSeconds;
            UpdateTimeRemainingDisplay();


            questionIndex = 0;

            ShowPlayerScore();
            ShowQuestion();
            isRoundActive = true;
        }

        private void ShowPlayerScore()
        {
            scoreDisplayText.text = "Score: " + playerScore.ToString();
        }

        private void ShowQuestion()
        {
            RemoveAnswerButtons();
            QuestionData questionData = questionPool[questionIndex];
            questionDisplayText.text = questionData.questionText;

            for (int i = 0; i < questionData.answers.Length; i++)
            {
                GameObject answerButtonGameObject = answerButtonObjectPool.GetObject();
                answerButtonGameObjects.Add(answerButtonGameObject);
                answerButtonGameObject.transform.SetParent(answerButtonParent);

                AnswerButton answerButton = answerButtonGameObject.GetComponent<AnswerButton>();
                answerButton.Setup(questionData.answers[i]);
            }
        }

        private void RemoveAnswerButtons()
        {
            while (answerButtonGameObjects.Count > 0)
            {
                answerButtonObjectPool.ReturnObject(answerButtonGameObjects[0]);
                answerButtonGameObjects.RemoveAt(0);
            }
        }

        public void AnswerButtonClicked(bool isCorrect)
        {
            playerMaxScore += currentRoundData.pointsAddedForCorrectAnswer;
            if (isCorrect)
            {
                playerScore += currentRoundData.pointsAddedForCorrectAnswer;
                scoreDisplayText.text = "Wynik: " + playerScore.ToString();
            }

            if (questionPool.Length > questionIndex + 1)
            {

                questionIndex++;
                ShowQuestion();
            }
            else
            {
                EndRound();
            }

        }

        public void EndRound()
        {
            isRoundActive = false;

            dataController.SubmitNewPlayerScore(playerScore);

            questionDisplay.SetActive(false);

            if (playerScore < playerMaxScore / 2)
            {
                inputNameDisplay.SetActive(true);
                inputFieldDisplay.SetActive(true);
            }
            else
            {
                roundEndDisplay.SetActive(true);

            }
        }

        public void GoToNextRound()
        {
            dataController.GetNextRound();

            SetUpRound();

            questionDisplay.SetActive(true);
            roundEndDisplay.SetActive(false);
        }

        public void ReturnToMenu()
        {

            dataController.ResetCurrentRound();
            SceneManager.LoadScene("SampleScene");
        }
        public void saveScoreboard()
        {
            wynik = playerScore;
            imie = namePlayer.GetComponent<Text>().text;
            scoreboard.AddEntry(new ScoreboardEntryData()
            {
                entryName = imie,
                entryScore = wynik
            });
            saveName();
        }
        public void saveName()
        {
            gameOverDisplay.SetActive(true);
            inputNameDisplay.SetActive(false);
            inputFieldDisplay.SetActive(false);
            //saveScoreboard();
        }
        public void ReplayGame()
        {
            
            dataController.ResetCurrentRound();
            SceneManager.LoadScene("MenuScene");
        }

        private void UpdateTimeRemainingDisplay()
        {
            timeRemainingDisplayText.text = "Czas: " + Mathf.Round(timeRemaining).ToString();
        }

        // Update is called once per frame
        void Update()
        {
            if (isRoundActive)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimeRemainingDisplay();

                if (timeRemaining <= 0f)
                {
                    EndRound();
                }

            }
        }
    }
}
