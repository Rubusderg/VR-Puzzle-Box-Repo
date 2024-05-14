using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side2OpenChecker : MonoBehaviour
{
    public DialAScript dialACheck;
    public DialBScript dialBCheck;
    public DialCScript dialCCheck;
    public DialDScript dialDCheck;

    public Rigidbody rb;
    //public Vector3 newPosition;

    private float moveDistance = 1.6f; // Distance to move upwards
    public float moveSpeed = 1.0f; // Speed of the movement

    private Vector3 targetPosition;
    public bool isMoving = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        targetPosition = transform.position + Vector3.left * moveDistance;
        //newPosition = new Vector3(-1.6f, transform.position.y, transform.position.z); 
    }

    // Update is called once per frame
    void Update()
    {
        if(dialACheck.correctValue && dialBCheck.correctValue && dialCCheck.correctValue && dialDCheck.correctValue)
        {
            //rb.MovePosition(newPosition);
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
