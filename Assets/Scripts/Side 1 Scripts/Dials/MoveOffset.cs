using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour
{
    public Rigidbody rb;
    public SideNegYController scriptDrawer;
    //public Vector3 newPosition;

    private float moveDistance = 1.6875f; // Distance to move upwards
    public float moveSpeed = 1.0f; // Speed of the movement

    private Vector3 targetPosition;
    public bool isMoving = false;
    private bool hasHappened = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //newPosition = new Vector3(transform.position.x, transform.position.y, 2.115f);
        targetPosition = transform.position + Vector3.forward * moveDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if(scriptDrawer.drawerOpen && !hasHappened)
        {
            isMoving = true;
            hasHappened = true;
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
}
