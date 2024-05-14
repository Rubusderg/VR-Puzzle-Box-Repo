using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnableBirds : MonoBehaviour
{
    private BoxCollider myCollider;

    public SideXChecker sideXChecker;

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
        if(sideXChecker.sideXOpen) 
        {
            myCollider.enabled = true;
            Debug.Log(myCollider.enabled);
        }
    }
}
