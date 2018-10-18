using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// DONE
[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour
{
	Text starText;
	int stars = 100;

	void Start ()
    {
		starText = GetComponent <Text>();
		UpdateDisplay();
	}
	
	public void AddStars(int amount) {
		stars += amount;
		UpdateDisplay();
	}
	
	public bool HaveEnoughStars(int amount)
	{
		return stars >= amount;
	}

	public void SpendStars(int amount)
    {
		if (stars >= amount)
        {
			stars -= amount;
			UpdateDisplay();
		}
	}
	
	private void UpdateDisplay()
    {
		starText.text = stars.ToString();
	}
	
}
