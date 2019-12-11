﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
       // Debug.Log(otherCollider);
        GameObject otherObject = otherCollider.gameObject;
        if (otherObject.GetComponent<Defender>()) {
            GetComponent<Attacker>().Attack(otherObject);
            Debug.Log("Touching", otherObject);
         }
    }
}
