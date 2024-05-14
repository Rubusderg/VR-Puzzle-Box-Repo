using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOpenMove : MonoBehaviour
{
    public Rigidbody rb;
    //public Vector3 newPosition;

    public float moveDistance = 1.6f; // Distance to move upwards
    public float moveSpeed = 1.0f; // Speed of the movement

    private Vector3 targetPosition;
    private bool isMoving = false;

    public Rigidbody birds1;
    public Rigidbody birds2;
    public Rigidbody birds3;
    public Rigidbody birds4;
    public Rigidbody birds5;

    public SideXChecker isOpen;
    private bool hasHappened = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //newPosition = new Vector3(1.6f, transform.position.y, transform.position.z);  
        targetPosition = transform.position + Vector3.right * moveDistance;       
    }

    // Update is called once per frame
    void Update()
    {

        if(isOpen.sideXOpen && !hasHappened)
        {
            /*rb.MovePosition(newPosition);
            birds1.MovePosition(newPosition);
            birds2.MovePosition(newPosition);
            birds3.MovePosition(newPosition);
            birds4.MovePosition(newPosition);
            birds5.MovePosition(newPosition);*/
            hasHappened=true;
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
