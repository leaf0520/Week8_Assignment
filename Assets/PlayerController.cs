using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float laneWidth = 2.0f; // Width of each lane
    public float moveSpeed = 5.0f; // Player's movement speed

    private int currentLane = 1; // The current lane the player is in (0 for left, 1 for center, 2 for right)

    void Update()
    {
        // Move left
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentLane > 0)
        {
            currentLane--;
        }
        // Move right
        else if (Input.GetKeyDown(KeyCode.RightArrow) && currentLane < 2)
        {
            currentLane++;
        }

        // Calculate the target position based on the current lane
        Vector3 targetPosition = new Vector3((currentLane - 1) * laneWidth, transform.position.y, transform.position.z);

        // Move the player using Vector3.Lerp for smooth movement
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
}