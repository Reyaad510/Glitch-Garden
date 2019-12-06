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
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 roundedPos)
    {
       
        GameObject newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as GameObject;
        Debug.Log(roundedPos);
    }
}
