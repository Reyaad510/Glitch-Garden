﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    private void OnMouseDown()
    {
        // looking for every object that has the defenderbutton script then puts them in a collection that you can do a foreach loop in
        // This controls the defenderbuttons to toggle from white to black(can only have one be white to show user what is selected that will be placed)
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(43, 43, 43, 255); // new Color32 means the rbg values and the three 43 refers to the grayed out color
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}