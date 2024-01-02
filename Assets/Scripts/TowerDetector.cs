using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDetector : MonoBehaviour
{
    public float boundingBoxSize = 5f;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(boundingBoxSize * 2, boundingBoxSize * 2, 0));
    }

    void Update()
    {
        // Get the player's position
        Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;

        // Check if the player is within the bounding box
        if (IsPlayerInsideBoundingBox(playerPosition))
        {
            // Do something when the player is inside the bounding box
            Debug.Log("Player is inside the bounding box!");
        }
    }

    bool IsPlayerInsideBoundingBox(Vector3 playerPosition)
    {
        // Get the tower's position
        Vector3 towerPosition = transform.position;

        // Calculate the distance between the tower and the player
        float distance = Vector3.Distance(towerPosition, playerPosition);

        // Check if the distance is within the bounding box size
        return distance <= boundingBoxSize;
    }
}
