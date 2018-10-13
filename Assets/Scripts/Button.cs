using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button : MonoBehaviour
{	
    [SerializeField] Defender defenderPrefab;

    void Start ()
    {
        LabelButtonWithStarCost();
    }

    private void LabelButtonWithStarCost()
    {
        Text costText = GetComponentInChildren<Text>();
        if (!costText) { Debug.LogError(name + " has no cost text"); }
        costText.text = defenderPrefab.GetStarCost().ToString();
    }

    void OnMouseDown ()
    {
        var buttons = FindObjectsOfType<Button>();
		foreach (Button button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = Color.black;
		}
		
		GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
	}
}
