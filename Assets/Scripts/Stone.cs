using UnityEngine;
using System.Collections;

// DONE
public class Stone : MonoBehaviour
{
    void OnTriggerStay2D (Collider2D otherCollider)
    {
		Attacker attacker = otherCollider.GetComponent<Attacker>();
		
		if (attacker)
        {
            GetComponent<Animator>().SetTrigger("underAttack"); 
		}
	}
}
