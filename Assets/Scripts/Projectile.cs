using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    [SerializeField] float speed = 1f;
    [SerializeField] float damage = 10f;

	void Update ()
    {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D otherCollider)
    {
		var attacker = otherCollider.gameObject.GetComponent<Attacker>();
		var health = otherCollider.gameObject.GetComponent<Health>();
		
		if (attacker && health)
        {
			health.DealDamage (damage);
			Destroy (gameObject);
		}
	}
}
