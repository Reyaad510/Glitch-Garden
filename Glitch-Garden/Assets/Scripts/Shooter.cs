using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;


    private void Start()
    {
        SetLaneSpawner();
    }

 private void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("Shoot!!!");
        }
        else
        {
            Debug.Log("Sit and Wait!");
        }
    }



    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }


    private bool IsAttackerInLane()
    {
            // Will say if there is an attacker in our lane
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity); // instantiated at gun position
    }
}
