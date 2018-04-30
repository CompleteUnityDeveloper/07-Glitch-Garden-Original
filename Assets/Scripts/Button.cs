using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button : MonoBehaviour
{	
    // configuration parameters, consdier SO
    [SerializeField] GameObject defenderPrefab;

    // private instance variables for state

    // cached references for readability
    Button[] buttons;
	public static GameObject selectedDefender; // todo remove static
		
    // messages, then public methods, then private methods...
	void Start ()
    {
		buttons = FindObjectsOfType<Button>();
		
        Text costText = GetComponentInChildren<Text>();
		if (!costText) { Debug.LogWarning (name + " has no cost text"); }
		
		costText.text = defenderPrefab.GetComponent<Defender>().GetStarCost().ToString();
	}

	void OnMouseDown ()
    {
		foreach (Button button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = Color.black;
		}
		
		GetComponent<SpriteRenderer>().color = Color.white;
		selectedDefender = defenderPrefab;
	}
}
