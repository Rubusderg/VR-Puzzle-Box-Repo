using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnableDials : MonoBehaviour
{
    private BoxCollider myCollider;

    public SideNegYController sideNegYController;

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
        if(sideNegYController.drawerOpen) 
        {
            myCollider.enabled = true;
            Debug.Log(myCollider.enabled);
        }
    }
}
