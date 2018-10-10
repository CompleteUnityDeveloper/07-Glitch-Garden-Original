using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	
	public float health = 100f;
    [SerializeField] GameObject hitVFX;

    public void DealDamage (float damage) {
		health -= damage;
		if (health < 0) {
            TriggerHitVFX();
			DestroyObject ();
		}
	}

    private void TriggerHitVFX()
    {
        GameObject hitImpactVFX = Instantiate(hitVFX, transform.position, transform.rotation);
        // Destroy(hitVFX, 1f);
    }

    // TODO: Does this need to be a public method?
    public void DestroyObject () {
		Destroy (gameObject);
	}
	
}
