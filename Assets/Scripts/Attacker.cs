using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Rigidbody2D))]
public class Attacker : MonoBehaviour
{
    // configuration parameters, consider SO

    // private instance variables for state
    [SerializeField] float movementSpeed = 1f;

    // cached references for readability
    GameObject currentTarget;
	
	// Update is called once per frame
	void Update ()
    {
		transform.Translate (Vector2.left * movementSpeed * Time.deltaTime);
		if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
		}
	}
	
	// Called from the animator at time of actual blow
	public void  StrikeCurrentTarget(float damage)
    {
		if (currentTarget)
        {
			Health health = currentTarget.GetComponent<Health>();
            if (currentTarget.GetComponent<Health>())
            {
				health.DealDamage (damage);
			}
		}
	}
	
	public void Attack(GameObject obj)
    {
		currentTarget = obj;
	}
}
