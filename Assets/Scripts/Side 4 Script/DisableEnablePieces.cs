using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnablePieces : MonoBehaviour
{
    private BoxCollider myCollider;

    public NumpadPassword numpadSolved;

    void Start()
    {
        myCollider = GetComponent<BoxCollider>();
        if (myCollider != null)
        {
            // Disable the collider
            myCollider.enabled = false;
            Debug.Log(myCollider.enabled);
        }
    }

    void Update()
    {
        if(numpadSolved.numpadCorrectOrder) 
        {
            myCollider.enabled = true;
            Debug.Log(myCollider.enabled);
        }
    }
}
