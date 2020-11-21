using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

//using UnityWebRequestModule;


public class DataController : MonoBehaviour
{
    
    //public UnityWebRequest();
    private RoundData[] allRoundData;

    private PlayerProgress playerProgress;

    private string gameDataFileName = "data.json";
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        LoadGameData();
        LoadPlayerProgress();

        SceneManager.LoadScene("MenuScene");
    }

    public RoundData GetCurrentRoundData()
    {
        return allRoundData[playerProgress.currentRound];
    }
    public void SubmitNewPlayerScore(int newScore)
    {
        // If newScore is greater than playerProgress.highestScore, update playerProgress with the new value and call SavePlayerProgress()
        if (newScore > playerProgress.highestScore)
        {
            playerProgress.highestScore = newScore;
            SavePlayerProgress();
        }
    }
    public bool HasMoreRounds()
    {
        return (allRoundData.Length - 1 > playerProgress.currentRound);
    }

    public void GetNextRound()
    {
        if(HasMoreRounds())
        {
            playerProgress.currentRound++;

            SaveCurrentRound();
        }
    }

    public int GetHighestPlayerScore()
    {
        return playerProgress.highestScore;
    }

    private void LoadPlayerProgress()
    {
        // Create a new PlayerProgress object
        playerProgress = new PlayerProgress();
        // If PlayerPrefs contains a key called "highestScore", set the value of playerProgress.highestScore using the value associated with that key
        if (PlayerPrefs.HasKey("highestScore"))
        {
            playerProgress.highestScore = PlayerPrefs.GetInt("highestScore");
        }

        if (PlayerPrefs.HasKey("currentRound"))
        {
            playerProgress.currentRound = PlayerPrefs.GetInt("currentRound");
        }
    }
    private void SavePlayerProgress()
    {
        // Save the value playerProgress.highestScore to PlayerPrefs, with a key of "highestScore"
        PlayerPrefs.SetInt("highestScore", playerProgress.highestScore);
    }

    private void SaveCurrentRound()
    {
        PlayerPrefs.SetInt("currentRound", playerProgress.currentRound);
    }

    public void ResetCurrentRound()
    {
        playerProgress.currentRound = 0;
        SaveCurrentRound();
    }

    private void LoadGameData()
    {
        string sFilePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);
        string sJson;
        if (Application.platform == RuntimePlatform.Android)
        {
            UnityWebRequest www = UnityWebRequest.Get(sFilePath);
            www.SendWebRequest();
            while (!www.isDone) ;
            sJson = www.downloadHandler.text;
        }
        else sJson = File.ReadAllText(sFilePath);
        GameData loadedData = JsonUtility.FromJson<GameData>(sJson);
        allRoundData = loadedData.allRoundData;
        /*string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);
        if (File.Exists(filePath))
        {
            // Read the json from the file into a string
            string dataAsJson = File.ReadAllText(filePath);
            // Pass the json to JsonUtility, and tell it to create a GameData object from it
            GameData loadedData = JsonUtility.FromJson<GameData>(dataAsJson);

            // Retrieve the allRoundData property of loadedData
            allRoundData = loadedData.allRoundData;
        }
        else
        {
            Debug.LogError("Cannot load game data!");
        }
        StartCoroutine(GetGames());*/
    }
    /*IEnumerator GetGames()
    {
        string url = "http://localhost/data.json";

        UnityWebRequest request = UnityWebRequest.Get(url);
        request.chunkedTransfer = false;
        yield return request.Send();

        if (request.isNetworkError)
        {
            //
        }
        else
        {
            if(request.isDone){
                GameData loadedData = JsonHelper.GetArray<GameData>(request.downloadHandler.text);
                allRoundData = loadedData.allRoundData;
            }
        }
    }*/

  
}
