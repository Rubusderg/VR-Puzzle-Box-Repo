using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPieceMove : MonoBehaviour
{
    // The transform to check against
    //public Transform targetTransform;
    public bool isKey = false;

    // The distance threshold to consider the object within the target transform
    //public float distanceThreshold = 0.05f;

    public FinalSideKeyCheck finalSideKeyCheck;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(finalSideKeyCheck.isOpen)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KeyPosition"))
        {
            isKey = true;
        }
    }
}
