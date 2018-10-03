using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Lizard : MonoBehaviour
{    
    // configuration parameters, consider SO

    // private instance variables for state
    bool isTongueOut;

    // cached references for readability
    private Attacker attacker;
    private Animator anim;


    // messages, then public methods, then private methods...
	void Start () {
		anim = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
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
		attacker.Attack (obj);
	}
}
