using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Notch5Script : MonoBehaviour
{
    public bool notch5ON = false;
    private bool buttonHit = false;
    private bool hasExecuted = false;
    [SerializeField] Transform notch5Transform;

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
            transform.Rotate(0f, 120f, 0f);
            notch5Transform.Rotate(0f, 90f, 0f);
            hasExecuted = true;
            notch5ON = true;
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
