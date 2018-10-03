using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Fox : MonoBehaviour {

	private Animator myAnimator;
	private Attacker attacker;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
	
	void OnTriggerEnter2D (Collider2D collider) {
		GameObject obj = collider.gameObject;

        // Leave the method if not colliding with defender
        if (obj.GetComponent<Stone>())
        {
            myAnimator.SetTrigger("jump trigger");
        }
        else if (obj.GetComponent<Defender>())
        {
            attacker.Attack(obj);
        }
	}
}
