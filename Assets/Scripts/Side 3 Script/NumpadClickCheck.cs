using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumpadClickCheck : MonoBehaviour
{
    private Vector3 originalPosition;
    public bool buttonHit = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            originalPosition = transform.position;
            transform.position -= transform.right * 0.01f;
            buttonHit = true;
        }
    }    
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            transform.position = originalPosition;
            buttonHit = false;
        }
    }    
}
