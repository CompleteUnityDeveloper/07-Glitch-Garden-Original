using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour
{
    const string DEFENDER_NAME = "Defenders";

    [SerializeField] AudioClip noDefenderSelected;

    private GameObject parent;

    // messages, then public methods, then private methods...
	void Start ()
    {
        CreateDefenderParent();
    }

    private void CreateDefenderParent()
    {
        parent = GameObject.Find(DEFENDER_NAME);
        if (!parent)
        {
            parent = new GameObject(DEFENDER_NAME);
        }
    }

    void OnMouseDown()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);

		GameObject defender = Button.selectedDefender;
        if (defender == null)
        {
            Debug.LogWarning("No defender selected");
            AudioSource.PlayClipAtPoint(noDefenderSelected, transform.position);
            return;
        }
		
		int defenderCost = defender.GetComponent<Defender>().GetStarCost();
        var starDisplay = FindObjectOfType<StarDisplay>();
		if (starDisplay.UseStars(defenderCost) == StarDisplay.Status.SUCCESS)
        {
			SpawnDefender(gridPos, defender);
		}
        else
        {
			Debug.Log ("Insufficient stars to spawn");
		}
	}

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

	private void SpawnDefender (Vector2 roundedPos, GameObject defender)
	{
		Quaternion zeroRot = Quaternion.identity;
		GameObject newDef = Instantiate (defender, roundedPos, zeroRot) as GameObject;
		newDef.transform.parent = parent.transform;
	}
	

	


}
