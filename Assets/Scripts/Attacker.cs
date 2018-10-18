using UnityEngine;
using System.Collections;

// DONE
public class Attacker : MonoBehaviour
{
    float currentSpeed;
    GameObject currentTarget; // target one at a time

    // Awake not Start() so doens't get called when enabled from the editor
    void Awake() 
    {
        FindObjectOfType<LevelController>().AttackerSpawned();
    }

    void OnDestroy()
    {
        FindObjectOfType<LevelController>().AttackerKilled();
    }

    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }

	// Called from the animator at time of actual blow
	public void StrikeCurrentTarget(float damage)
    {
        if (!currentTarget) { return; }

		Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
			health.DealDamage (damage);
		}
	}
	
	public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
	}
}
