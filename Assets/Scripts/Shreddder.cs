using UnityEngine;
using System.Collections;

public class Shreddder : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		Destroy (collider.gameObject);	
	}
	
}
