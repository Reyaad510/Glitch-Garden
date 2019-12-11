using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
  
{


    [Range(0f, 5f)] float currentSpeed = 1f;
    GameObject currentTarget;


    private void Awake()
    {
        // when attacker born will call this
        FindObjectOfType<LevelController>().AttackerSpawned();
    }

    private void OnDestroy()
    {
        //when attacker killed call this
        FindObjectOfType<LevelController>().AttackerKilled();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    // when attacker destroys defender then will stop attacking
    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }


    // This is created in Animation event in Lizard Walk animation
    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage)
    {
        if (!currentTarget) { return; }
        Health health = currentTarget.GetComponent<Health>();

        if (health)
        {
            health.DealDamage(damage);
           
        }
    }

}
