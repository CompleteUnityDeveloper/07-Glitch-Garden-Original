using UnityEngine;

// DONE
[RequireComponent(typeof(Attacker))]
public class Fox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        // Explicitly specify behaviour for each attacker
        if (otherObject.GetComponent<Stone>())
        {
            GetComponent<Animator>().SetTrigger("jump trigger");
        }
        else if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}