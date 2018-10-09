using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

	[SerializeField] float levelSeconds = 100;

	Slider slider;
	AudioSource audioSource;
	bool isEndOfLevel = false;
	LevelManager levelManager;
	GameObject winLabel;
    Spawner spawner;

	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider>();
		audioSource = GetComponent<AudioSource>();
		levelManager = FindObjectOfType<LevelManager>();
		FindYouWin();
		winLabel.SetActive(false);
	}

	void FindYouWin()
	{
		winLabel = GameObject.Find ("You Win");
		if (!winLabel) {
			Debug.LogWarning ("Please create You Win object");
		}
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = Time.timeSinceLevelLoad / levelSeconds;
		
		bool timeIsUp = (Time.timeSinceLevelLoad >= levelSeconds);
		if (timeIsUp && !isEndOfLevel)
        {
            StopSpawners();
            HandleWinCondition ();
		}
	}
    // TODO: new addition, check its kewl
    private void StopSpawners()
    {
        Spawner[] spawnerArray = FindObjectsOfType<Spawner>();
        foreach (Spawner spawner in spawnerArray)
        {
            Destroy(spawner);
        }
    }

    void HandleWinCondition ()
	{        
        //DestroyAllTaggedObjects();
		audioSource.Play ();
		winLabel.SetActive (true);
		Invoke ("LoadNextLevel", 10f); // TODO Change Invoke to Coroutine?
		isEndOfLevel = true;
	}
	
	// Destroys all objects with destroyOnWin tag
    // TODO: Remove?
	void DestroyAllTaggedObjects() {
		GameObject[] taggedObjectArray = GameObject.FindGameObjectsWithTag ("destroyOnWin");
		
		foreach (GameObject taggedObject in taggedObjectArray) {
			Destroy (taggedObject);
		}
	}
	
	void LoadNextLevel () {
		levelManager.LoadNextLevel();
	}
}