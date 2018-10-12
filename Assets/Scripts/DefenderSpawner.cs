using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] AudioClip noDefenderSelected;
    GameObject parent;
    GameObject selectedDefender;
    const string DEFENDER_NAME = "Defenders";

	void Start ()
    {
        CreateDefenderParent();
    }

    public void SetSelectedDefender(GameObject defenderToSelect)
    {
        selectedDefender = defenderToSelect;
    }

    private void CreateDefenderParent()
    {
        parent = GameObject.Find(DEFENDER_NAME);
        if (!parent)
        {
            parent = new GameObject(DEFENDER_NAME);
        }
    }

    // TODO - Ben, lets have a look at this big old method together
    void OnMouseDown()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);

		GameObject defender = selectedDefender;
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
