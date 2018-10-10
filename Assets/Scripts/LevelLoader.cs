using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour {

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadYouLose()
    {
        SceneManager.LoadScene("03b Lose");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}