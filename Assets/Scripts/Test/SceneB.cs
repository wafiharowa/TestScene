using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneB : MonoBehaviour
{
    public void GoToSceneA()
    {
        SceneManager.LoadScene("TestA");
    }
}
