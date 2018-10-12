using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

	Text starText;
	int stars = 100;
    // TODO Remove public enum
    public enum Status {SUCCESS, FAILURE};
    

	void Start ()
    {
		starText = GetComponent <Text>();
		UpdateDisplay();
	}
	
	public void AddStars (int amount) {
		stars += amount;
		UpdateDisplay();
	}
	
	public Status UseStars (int amount)
    {
		if (stars >= amount) {
			stars -= amount;
			UpdateDisplay();
			return Status.SUCCESS;
		}
		return Status.FAILURE;
	}
	
	private void UpdateDisplay ()
    {
		starText.text =stars.ToString();
	}
	
}
