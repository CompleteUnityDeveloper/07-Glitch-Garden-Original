using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    // break out into LevelLoader (loading stuff) and LevelSession (win criteria stuff)

    int numberOfAttackers = 0;
    bool levelTimerFinished = false;
    [SerializeField] float waitToLoad = 3f;

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
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        audioSource.Play();
        winLabel.SetActive(true);
        yield return new WaitForSeconds(waitToLoad);
        FindObjectOfType<LevelLoader>().LoadNextScene();
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
}
