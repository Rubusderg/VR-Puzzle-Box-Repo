using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialBScript : MonoBehaviour
{
    public int dialCounter = 1;
    public Transform dial;

    public Transform dialEmpty;
    public Transform numberEmpty;

    public bool correctValue = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Rotate the object along its Z axis by 40 degrees
            transform.RotateAround(dialEmpty.position, Vector3.right, 40f);
            dial.transform.RotateAround(numberEmpty.position, Vector3.up, 40f);
            if(dialCounter >8)
            {
                dialCounter = 0;
            }
            dialCounter++;

            Debug.Log(dialCounter);
        }*/

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            // Rotate the object along its Z axis by 40 degrees
            transform.RotateAround(dialEmpty.position, Vector3.left, 40f);
            dial.transform.RotateAround(numberEmpty.position, Vector3.up, 40f);
            if(dialCounter <8)
            {
                dialCounter++;
            }
            if(dialCounter >=8)
            {
                dialCounter = 0;
            }

            Debug.Log(dialCounter);
        }

        if (dialCounter == 3)
        {
            correctValue = true;
        }
        else
        {
            correctValue = false;
        }
    }
}
