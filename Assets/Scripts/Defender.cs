using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour
{	
    // configuration parameters, consider SO
    [SerializeField] int starCost = 100;

    public int GetStarCost()
    {
        return starCost;
    }
}
