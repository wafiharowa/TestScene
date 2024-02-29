using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SingletonData
{
    private SingletonData() { }

    private static SingletonData _instance = null;
    public static SingletonData Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SingletonData();
            }
            return _instance;
        }
    }

    public int CurrentScore = 0;
    public int HighScore = 0;

    public void AddScore(int score)
    {
        CurrentScore += score;
        if(CurrentScore > HighScore)
        {
            HighScore = CurrentScore;
        }
    }

    public void ResetScore()
    {
        CurrentScore = 0;
    }
}
