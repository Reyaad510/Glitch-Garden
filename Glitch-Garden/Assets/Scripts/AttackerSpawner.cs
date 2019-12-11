using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackerPrefabArray;
    bool spawn = true; // use to stop waves when level ends


    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
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
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
    
    }

    private void Spawn(Attacker myAttacker)
    {
        if(!myAttacker) { return; };

        Attacker newAttacker = Instantiate(myAttacker, transform.position, Quaternion.identity) as Attacker;
        newAttacker.transform.parent = transform; // Allows us to spawn a new attacker as a child to the game object which instaniated it. (Go to unity and look under Spawners and play game. When enemy appear it will show which spawned them)

    }

    // Update is called once per frame
    void Update()
    {
        
    }






}
