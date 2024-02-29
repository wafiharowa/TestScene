using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeScene : MonoBehaviour
{
    [SerializeField]
    private Text highScore;

    private void Awake()
    {
        //Set highscore text using 3 method

        // method 1 : Static Variable
        //highScore.text = StaticData.HighScore.ToString();

        // method 2 : Static Object
        //highScore.text = GameData.Data.HighScore.ToString();

        // method 3 : Singleton
        highScore.text = SingletonData.Instance.HighScore.ToString();
    }

    public void GotoPlayScene(){
        Debug.Log("Go to Play Scene");
        SceneManager.LoadScene("Gameplay");
    }

    
}
