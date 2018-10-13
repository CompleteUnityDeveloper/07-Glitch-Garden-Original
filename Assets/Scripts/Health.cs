using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    [SerializeField] GameObject deathVFX;
    [SerializeField] float health = 100f;

    public void DealDamage (float damage)
    {
		health -= damage;
		if (health < 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
		}
	}

    private void TriggerDeathVFX()
    {
        if (!deathVFX) { return; }
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, 1f);
    }
}
