using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    [SerializeField] bool isPlaceable;
    // The following is considered a "Property"
    public bool IsPlaceable { get { return isPlaceable; } }
   
   
    void OnMouseDown() 
    {
        if(isPlaceable)
        {
            bool isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);
            isPlaceable = !isPlaced;
        }

    }
}
