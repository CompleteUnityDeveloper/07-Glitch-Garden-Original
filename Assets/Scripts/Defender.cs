using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {
	
	private StarDisplay starDisplay;

	void Start () {
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}
	
	// Only being used as a tag for now!
	public void AddStars (int amount) {
		starDisplay.AddStars (amount);
	}
}
