using UnityEngine;
using System.Collections;

[SelectionBase]
public class Defender : MonoBehaviour
{	
    [SerializeField] int starCost = 100;

    public int GetStarCost()
    {
        return starCost;
    }

    public void AddStars(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStars (amount);
	}
}
