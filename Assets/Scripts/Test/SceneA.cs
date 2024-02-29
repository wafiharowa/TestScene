using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneA : MonoBehaviour
{
    public void GoToSceneB()
    {
        SceneManager.LoadScene("TestB");
    }
}
