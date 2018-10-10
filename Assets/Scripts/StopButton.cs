using UnityEngine;
using System.Collections;

public class StopButton : MonoBehaviour {

	LevelManager levelManager;
	
	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
	}

	void OnMouseDown() {
		//levelManager.LoadLevel ("01a Start");
	}
}
