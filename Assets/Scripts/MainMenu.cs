using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string startSceneName;

    public void PlayGame()
    {
        SceneManager.LoadScene(startSceneName, LoadSceneMode.Single);
    }

    public void Options()
    {
        Debug.LogError("Options Not Implemented");
    }

    public void Credits()
    {
        Debug.LogError("Credits Not Implemented");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
