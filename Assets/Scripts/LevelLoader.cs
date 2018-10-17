using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour {

    [SerializeField] int waitInSeconds = 2;
    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(currentSceneIndex);
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForSeconds());
        }
    }

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(waitInSeconds);
        LoadNextScene();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadYouLose()
    {
        SceneManager.LoadScene("Lose Screen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}