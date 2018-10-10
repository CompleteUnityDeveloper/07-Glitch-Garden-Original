using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StopButton : MonoBehaviour {

	LevelLoader levelLoader;
	
	// Use this for initialization
	void Start () {
		levelLoader = FindObjectOfType<LevelLoader>();
	}

	void OnMouseDown() {
		levelLoader.LoadStartMenu();
	}
}
