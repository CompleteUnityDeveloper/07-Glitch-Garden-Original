using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {
    // rename class to GameSession or something similar

	[SerializeField] float levelSeconds = 100;

	Slider slider;
	LevelManager levelManager;

    bool triggeredLevelFinished = false;

    // Use this for initialization
    void Start ()
    {
		slider = GetComponent<Slider>();
		levelManager = FindObjectOfType<LevelManager>();
	}

	// Update is called once per frame
	void Update ()
    {
        if (triggeredLevelFinished) { return; }
		slider.value = Time.timeSinceLevelLoad / levelSeconds;

        bool timerFinished = Time.timeSinceLevelLoad >= levelSeconds;
        if (timerFinished)
        {
            levelManager.LevelTimerFinished();
            triggeredLevelFinished = true;
		}
	}
 }