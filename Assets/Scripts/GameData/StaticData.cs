using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData
{
    public static int CurrentScore = 0;
    public static int HighScore = 0;

    public static void ResetScore()
    {
        CurrentScore = 0;
    }

    public static void AddScore(int score)
    {
        CurrentScore += score;
        if (CurrentScore > HighScore)
        {
            HighScore = CurrentScore;
        }
    }
}
