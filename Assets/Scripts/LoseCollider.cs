using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {


    void OnTriggerEnter2D ()
    {
        FindObjectOfType<LevelLoader>().LoadYouLose();
	}
}
