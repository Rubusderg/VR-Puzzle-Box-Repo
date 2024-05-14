using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalSideKeyCheck : MonoBehaviour
{
    public bool isOpen = false;

    public float moveDistance = 1.6f; // Distance to move upwards
    public float moveSpeed = 1.0f; // Speed of the movement

    private Vector3 targetPosition;
    public bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position - Vector3.forward * moveDistance; 
    }

    // Update is called once per frame
    void Update()
    {
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinalKey"))
        {
            isOpen = true;
            isMoving = true;
        }
    }
}
