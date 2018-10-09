using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	
	public float health = 100f;
	
	public void DealDamage (float damage) {
		health -= damage;
		if (health < 0) {
			// Optionally trigger animation
			DestroyObject ();
		}
	}
	
    // TODO: Does this need to be a public method?
	public void DestroyObject () {
		Destroy (gameObject);
	}
	
}
