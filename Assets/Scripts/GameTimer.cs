using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

	public float levelSeconds = 100;
	
	private Slider slider;
	private LevelManager levelManager;
	private AudioClip audioClip;

	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider>();
		audioClip = GetComponent<AudioClip>();
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = Time.timeSinceLevelLoad / levelSeconds;
		
		if (Time.timeSinceLevelLoad >= levelSeconds) { // Level won
			audio.Play();
			levelManager.LoadNextLevel();
		}
	}
}
