using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public static GameData Data = new GameData();

    public int CurrentScore = 0;
    public int HighScore = 0;

    public void AddScore(int score)
    {
        CurrentScore += score;
        if (CurrentScore > HighScore)
        {
            HighScore = CurrentScore;
        }
        // test dummy
    }

    public void ResetScore()
    {
        CurrentScore = 0;
        // test commit dari github browser
    }
}
