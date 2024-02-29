using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameplayScene : MonoBehaviour
{
    [SerializeField]
    private Text currentScore;
    [SerializeField]
    private Text highScore;


    private void Awake()
    {
        ResetScore();
    }

    private void ResetScore()
    {
        // reset score using 3 method
        // method 1 : Static Variable
        //StaticData.ResetScore();

        // method 2 : Static Object
        //GameData.Data.ResetScore();

        // method 3 : Singleton
        SingletonData.Instance.ResetScore();
        RefreshScore();
    }

    private void RefreshScore()
    {
        // method 1 : Static Variable
        //currentScore.text = StaticData.CurrentScore.ToString();
        //highScore.text = StaticData.HighScore.ToString();

        // method 2 : Static Object
        //currentScore.text = GameData.Data.CurrentScore.ToString();
        //highScore.text = GameData.Data.HighScore.ToString();

        // method 3 : Singleton
        currentScore.text = SingletonData.Instance.CurrentScore.ToString();
        highScore.text = SingletonData.Instance.HighScore.ToString();
    }

    public void AddScore(int score)
    {
        // add score using 3 method
        // method 1 : Static Variable
        //StaticData.AddScore(score);

        // method 2 : Static Object
        //GameData.Data.AddScore(score);

        // method 3 : Singleton
        SingletonData.Instance.AddScore(score);

        RefreshScore();
    }


    public void GotoHomeScene()
    {
        Debug.Log("Go to Home Scene");
        SceneManager.LoadScene("Home");
    }
}
