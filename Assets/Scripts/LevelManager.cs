using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    // break out into LevelLoader (loading stuff) and LevelSession (win criteria stuff)

	[SerializeField] float autoLoadNextLevelAfter;
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;

    AudioSource audioSource;
    GameObject winLabel;

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
        if (numberOfAttackers <= 0 && levelTimerFinished)
        {
            HandleWinCondition();
        }
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    void Start () {
        audioSource = GetComponent<AudioSource>();
        FindYouWin();
        winLabel.SetActive(false);
        
        // TODO: Deal with all the loading crazies
        if (autoLoadNextLevelAfter <= 0)
        {
			Debug.Log ("Level auto load disabled, use a postive number is seconds");
		}
        else
        {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

    void FindYouWin()
    {
        winLabel = GameObject.FindWithTag("WinMessageOverlay");
        if (!winLabel)
        {
            Debug.LogWarning("Please create You Win object");
        }
    }

    private void StopSpawners()
    {
        Spawner[] spawnerArray = FindObjectsOfType<Spawner>();
        foreach (Spawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }

    void HandleWinCondition()
    {
        audioSource.Play();
        winLabel.SetActive(true);
        // LoadNextLevel
    }

    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(Application.loadedLevel + 1);
    }

    //void LoadNextLevel()
    //{
    //    levelManager.LoadNextLevel();
    //}
    
}
