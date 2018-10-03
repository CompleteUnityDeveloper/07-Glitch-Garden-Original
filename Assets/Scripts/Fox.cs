using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Fox : MonoBehaviour {

	private Animator myAnimator;
	private Attacker myAttacker;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator>();
		myAttacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D (Collider2D collider) {
		GameObject obj = collider.gameObject;
		
		// Leave the method if not colliding with defender
		if (!obj.GetComponent<Defender>()) {
			return;
		}
		
		if (obj.GetComponent<Stone>()) {
			myAnimator.SetTrigger ("jump trigger");
		} else {
			myAnimator.SetBool ("isAttacking", true);
			myAttacker.Attack (obj);
		}
	}
}
