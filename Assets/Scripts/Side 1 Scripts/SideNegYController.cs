using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SideNegYController : MonoBehaviour
{
    public bool drawerOpen = false;
    //public float startZ; // Initial position of the object
    //public float targetZ; // Final position of the object
    [SerializeField] private Collider handleCollider;

    public Notch1Script notch1script;
    public Notch2Script notch2script;
    public Notch3Script notch3script;
    public Notch4Script notch4script;
    public Notch5Script notch5script;


    public float moveDistance = 1.6f; // Distance to move upwards
    public float moveSpeed = 1.0f; // Speed of the movement

    private Vector3 targetPosition;
    public bool isMoving = false;


    public Rigidbody rb;
    //public Vector3 movePosition; // Declare movePosition at the class level
    //public Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        targetPosition = transform.position + Vector3.forward * moveDistance; 

        // Record the initial position
        //startZ = transform.position.z;
        //targetZ = startZ - 0.015f; // Calculate the target position

        // Calculate move position based on target position
        //movePosition = new Vector3(transform.position.x, transform.position.y, targetZ);
        //newPosition = new Vector3(transform.position.x, transform.position.y, 1.6f);
    }

    // Update is called once per frame
    void Update()
    {
        if (drawerOpen && notch1script.notch1ON && notch2script.notch2ON && notch3script.notch3ON && notch4script.notch4ON && notch5script.notch5ON)
        {
            // Move the object towards the target position using Lerp
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

            //rb.MovePosition(newPosition);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand") || (notch1script.notch1ON && notch2script.notch2ON && notch3script.notch3ON && notch4script.notch4ON && notch5script.notch5ON))
        {
            drawerOpen = true;
            isMoving = true;
        }
    }
}
