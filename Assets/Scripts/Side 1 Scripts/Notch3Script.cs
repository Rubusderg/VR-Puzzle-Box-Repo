using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Notch3Script : MonoBehaviour
{
    public bool notch3ON = false;
    private bool buttonHit = false;
    private bool hasExecuted = false;

    // Start is called before the first frame update
    void Start()
    {
        Transform objectTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonHit == true && !hasExecuted)
        {
            transform.Rotate(0f, 210f, 0f);
            hasExecuted = true;
            notch3ON = true;
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            buttonHit = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            buttonHit = true;
        }
    }
}
