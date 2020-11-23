using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.CodeDom;
using System.Globalization;
using System.Linq;

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
        public AudioSource dobraodp;
        public AudioSource zlaodp;

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
        private int poziom;
        private int numberQuestion;
        private int currentRound;

        private List<GameObject> answerButtonGameObjects = new List<GameObject>();
        private List<int> questionIndexesChosen = new List<int>();

        // Use this for initialization
        void Start()
        {
            dataController = FindObjectOfType<DataController>();
            currentRound = PlayerPrefs.GetInt("currentRound");
            playerScore = PlayerPrefs.GetInt("Score");
            playerMaxScore = PlayerPrefs.GetInt("ScoreMax");
            poziom = PlayerPrefs.GetInt("Poziom");
            numberQuestion = 0;


            SetUpRound();
        }

        public void SetUpRound()
        {
            currentRoundData = dataController.GetCurrentRoundData();
            questionPool = currentRoundData.questions;
            


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
            timeRemaining = currentRoundData.timeLimitInSeconds;
            UpdateTimeRemainingDisplay();
            Debug.Log("runda: " + currentRoundData);
            Debug.Log("pytanie: " + numberQuestion);
            
            RemoveAnswerButtons();
            ChooseQuestion();
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
        void ChooseQuestion()
        {
            bool questionChosen = false;

            while (questionChosen != true) // While question chosen does not equal true
            {

                int random = Random.Range(0, questionPool.Length); // Choose a random number between 0 and the questionPool length

                if (!questionIndexesChosen.Contains(random)) // If the new list doesn't contain the number
                {
                    questionIndexesChosen.Add(random); // Add the number to the list
                    questionIndex = random; // Set the questionIndex to the number
                    questionChosen = true; // Set questionChosen to true to end the while loop
                }
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
            numberQuestion += 1;
            if (isCorrect)
            {
                dobraodp.Play();
                playerScore += currentRoundData.pointsAddedForCorrectAnswer;
                scoreDisplayText.text = "Wynik: " + playerScore.ToString();


            }
            else { zlaodp.Play(); }
            if (currentRound == 23)
            {
                if (numberQuestion < 10)
                {
                    questionIndex++;
                    ShowQuestion();
                    
                }
                else
                {
                    KoniecGry();
                }
            }
            else
            {
                // aula= 9 runda
                
                if (currentRound == 9 || currentRound == 16)
                {
                    if (numberQuestion < 5)
                    {
                        questionIndex++;
                        ShowQuestion();
                    }
                    else
                    {
                        EndRoundAula();
                    }
                }
                else
                {
                    if (numberQuestion < 3)
                    {
                        questionIndex++;
                        ShowQuestion();
                    }
                    else
                    {
                        EndRound();
                    }


                }
            }

        }

        public void KoniecGry()
        {
            isRoundActive = false;

            dataController.SubmitNewPlayerScore(playerScore);

            questionDisplay.SetActive(false);

            
          
             inputNameDisplay.SetActive(true);
             inputFieldDisplay.SetActive(true);
           
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

        public void EndRoundAula()
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
                PlayerPrefs.SetInt("Poziom", poziom +1);
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
        public void ReturnToClass()
        {
            SceneManager.LoadScene("SampleScene");
        }
        public void ReturnToMenu()
        {
            dataController.GetNextRound();
            PlayerPrefs.SetInt("Score", playerScore);
            PlayerPrefs.SetInt("ScoreMax", playerMaxScore);
            //dataController.ResetCurrentRound();
            
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
