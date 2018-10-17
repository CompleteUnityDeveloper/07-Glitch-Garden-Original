using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] AudioClip noDefenderSelected;
    GameObject parent;
    Defender selectedDefender;
    const string DEFENDER_PARENT_NAME = "Defenders";

	void Start ()
    {
        CreateDefenderParent();
    }

    public void SetSelectedDefender(Defender defenderToSelect) // From UI
    {
        selectedDefender = defenderToSelect;
    }

    private void CreateDefenderParent()
    {
        parent = GameObject.Find(DEFENDER_PARENT_NAME);
        if (!parent)
        {
            parent = new GameObject(DEFENDER_PARENT_NAME);
        }
    }

    void OnMouseDown()
    {
        PlaySoundIfNoSelectedDefender();
        AttemptToPlaceDefenderAt(GetGridSquareClicked());
    }

    private void PlaySoundIfNoSelectedDefender()
    {
        if (selectedDefender == null)
        {
            Debug.LogWarning("No defender selected");
            AudioSource.PlayClipAtPoint(noDefenderSelected, transform.position);
            return;
        }
    }

    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        int defenderCost = selectedDefender.GetStarCost();
        var starDisplay = FindObjectOfType<StarDisplay>();
        if (starDisplay.UseStars(defenderCost) == StarDisplay.Status.SUCCESS)
        {
            SpawnDefender(gridPos, selectedDefender.gameObject);
        }
        else
        {
            Debug.Log("Insufficient stars to spawn");
        }
    }

    private Vector2 GetGridSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

	private void SpawnDefender(Vector2 roundedPos, GameObject defender)
	{
		Quaternion zeroRot = Quaternion.identity;
		GameObject newDef = Instantiate (defender, roundedPos, zeroRot) as GameObject;
		newDef.transform.parent = parent.transform;
	}
}
