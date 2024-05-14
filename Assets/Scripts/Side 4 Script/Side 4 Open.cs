using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side4Open : MonoBehaviour
{
    public NumpadPassword numpadCheck;
    private bool hasHappened = false;

    public float moveDistance = 1.6f; // Distance to move upwards
    public float moveSpeed = 1.0f; // Speed of the movement

    private Vector3 targetPosition;
    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position + Vector3.up * moveDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if(numpadCheck.numpadCorrectOrder && !hasHappened)
        {
            hasHappened = true;
            isMoving = true;
        }
    
        if (isMoving)
        {
            // Calculate the new position using Lerp for smooth movement
            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Check if the object has reached close enough to the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                // Stop moving and snap to the exact target position
                transform.position = targetPosition;
                isMoving = false;
            }
        }
    }
}
