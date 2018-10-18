using UnityEngine;
using System.Collections;

// DONE
public class Shreddder : MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D otherCollider)
    {
		Destroy (otherCollider.gameObject);	
	}
	
}
