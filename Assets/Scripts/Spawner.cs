using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    // configuration parameters, consider SO
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] GameObject[] attackerPrefabArray;

    [SerializeField] bool spawn;

    IEnumerator Start()
    {
        while (spawn == true)
        {
            // delay before spawning
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void SpawnAttacker()
    {
        // get attacker index
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        // spawn the attacker from the array
        Spawn(attackerPrefabArray[attackerIndex]);
    }

	void Spawn(GameObject myGameObject)
    {
		GameObject myAttacker = Instantiate (myGameObject) as GameObject;
		myAttacker.transform.parent = transform;
		myAttacker.transform.position = transform.position;
	}
}
