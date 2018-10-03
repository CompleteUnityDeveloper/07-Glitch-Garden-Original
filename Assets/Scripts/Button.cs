using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button : MonoBehaviour
{	
    // configuration parameters, consdier SO
    [SerializeField] GameObject defenderPrefab;

    DefenderSpawner defenderSpawner;

    Button[] buttons;

    void Start ()
    {
        defenderSpawner = FindObjectOfType<DefenderSpawner>();
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
        defenderSpawner.SetSelectedDefender(defenderPrefab);
	}
}
