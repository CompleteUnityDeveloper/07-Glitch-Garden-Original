using UnityEngine;
using System.Collections;

// DONE
public class LoseCollider : MonoBehaviour {
    
    void OnTriggerEnter2D ()
    {
        FindObjectOfType<LevelLoader>().LoadYouLose();
	}
}
