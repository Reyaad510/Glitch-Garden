﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
   [SerializeField] float minSpawnDelay = 1f;
   [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker attackerPrefab;
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

    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }






}
