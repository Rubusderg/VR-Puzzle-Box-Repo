using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTileMovement : MonoBehaviour
{
    public bool isBeingGrabbed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isBeingGrabbed)
        {
            
        }
    }

    public void Grab()
    {
        isBeingGrabbed = true;
    }

    public void LetGo()
    {
        isBeingGrabbed = false;
    }
}

/*Positions:
1 0.64
2 0.39
3 0.16
4 -0.15
5 -0.35*/