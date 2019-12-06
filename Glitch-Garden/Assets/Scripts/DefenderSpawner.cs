using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        // Debug.Log("Mouse was clicked!");
     
        SpawnDefender(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y); // where we click
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos); // converting position to world to fit camera
        return worldPos;
    }

    private void SpawnDefender(Vector2 worldPos)
    {
       
        GameObject newDefender = Instantiate(defender, worldPos, Quaternion.identity) as GameObject;
    }
}
