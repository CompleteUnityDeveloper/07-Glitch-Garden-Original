using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    // configuration parameters, consider SO
    [SerializeField] GameObject[] attackerPrefabArray;

    // private instance variables for state

    // cached references for readability

    // messages, then public methods, then private methods...
	void Update ()
    {
		foreach (GameObject thisAttacker in attackerPrefabArray)
        {
			if (isTimeToSpawn(thisAttacker))
            {
				Spawn(thisAttacker);
		   	}
		}	
	}
	
	void Spawn(GameObject myGameObject)
    {
		GameObject myAttacker = Instantiate (myGameObject) as GameObject;
		myAttacker.transform.parent = transform;
		myAttacker.transform.position = transform.position;
	}
	
	bool isTimeToSpawn(GameObject attackerGameObject)
    {
		Attacker attacker = attackerGameObject.GetComponent<Attacker>();

        float meanSpawnDelay = attacker.GetSpawnsPerSecond();
		if (Time.deltaTime > meanSpawnDelay)
        {
			Debug.LogWarning ("Spwan rate capped by frame rate");
		}
        float threshold = Time.deltaTime / meanSpawnDelay;
		return (Random.value < threshold);
	}
}
