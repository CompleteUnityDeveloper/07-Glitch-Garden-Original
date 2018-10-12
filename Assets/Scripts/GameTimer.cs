using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {
    
	[SerializeField] float levelSeconds = 100;
    bool triggeredLevelFinished = false;

	void Update ()
    {
        if (triggeredLevelFinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelSeconds;

        bool timerFinished = Time.timeSinceLevelLoad >= levelSeconds;
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggeredLevelFinished = true;
		}
	}
 }