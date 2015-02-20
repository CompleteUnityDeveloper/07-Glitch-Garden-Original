using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

	private Text starText;
	private int stars = 0;

	// Use this for initialization
	void Start () {
		starText = GetComponent <Text>();
	}
	
	public void AddStars (int amount) {
		stars += amount;
		UpdateDisplay();
	}
	
	public void UseStars (int amount) {
		stars -= amount;
		UpdateDisplay();
	}
	
	private void UpdateDisplay () {
		starText.text =stars.ToString();
	}
	
}
