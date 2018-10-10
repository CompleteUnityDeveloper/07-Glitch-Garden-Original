using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

    int numberOfAttackers = 0;
    bool levelTimerFinished = false;
    [SerializeField] float waitToLoad = 3f;

    AudioSource audioSource;
    GameObject winLabel;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        FindYouWin();
        winLabel.SetActive(false);
    }

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
