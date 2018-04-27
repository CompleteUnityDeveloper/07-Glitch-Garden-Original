using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour
{	
    // configuration parameters, consider SO
    [SerializeField] int starCost = 100;
	
	private StarDisplay starDisplay;
    // private instance variables for state

    // cached references for readability

    // messages, then public methods, then private methods...
	void Start ()
    {
		starDisplay = FindObjectOfType<StarDisplay>();
	}
	
	// Only being used as a tag for now!
	public void AddStars(int amount)
    {
		starDisplay.AddStars (amount);
	}

    public int GetStarCost()
    {
        return starCost;
    }
}
