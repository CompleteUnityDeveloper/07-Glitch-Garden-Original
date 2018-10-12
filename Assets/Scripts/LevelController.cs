using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

    [SerializeField] float waitToLoad = 3f;
    GameObject winLabel;
    bool levelTimerFinished = false;
    int numberOfAttackers = 0;

    void Start()
    {
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
        GetComponent<AudioSource>().Play();
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
            Debug.LogWarning("Please create a You Win object");
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
