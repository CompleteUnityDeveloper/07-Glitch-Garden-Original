using UnityEngine;

[RequireComponent (typeof (Attacker))]
public class Fox : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<Stone>())
        {
            GetComponent<Animator>().SetTrigger("jump trigger");
        }
	}
}