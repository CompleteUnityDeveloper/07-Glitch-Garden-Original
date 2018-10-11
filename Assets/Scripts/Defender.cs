using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour
{	
    [SerializeField] int starCost = 100;
	
	public void AddStars(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStars (amount);
	}

    public int GetStarCost()
    {
        return starCost;
    }
}
