using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// DONE
public class StopButton : MonoBehaviour {

	void OnMouseDown()
    {
        FindObjectOfType<LevelLoader>().LoadStartMenu();
	}
}
