using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NumpadPassword : MonoBehaviour
{
    public NumpadClickCheck numpad1;
    public NumpadClickCheck numpad2;
    public NumpadClickCheck numpad3;
    public NumpadClickCheck numpad4;
    public NumpadClickCheck numpad5;
    public NumpadClickCheck numpad6;
    public NumpadClickCheck numpad7;
    public NumpadClickCheck numpad8;
    public NumpadClickCheck numpad9;

//Array!!!
    public bool order1Triggered = false;
    public bool order2Triggered = false;
    public bool order3Triggered = false;
    public bool order4Triggered = false;
    public bool order5Triggered = false;

    public bool numpadCorrectOrder = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            if (numpad5.buttonHit && !order1Triggered)
            {
                order1Triggered = true;
            }
            else if (numpad2.buttonHit && order1Triggered && !order2Triggered)
            {
                order2Triggered = true;
            }
            else if (numpad1.buttonHit && order2Triggered && !order3Triggered)
            {
                order3Triggered = true;
            }
            else if (numpad6.buttonHit && order3Triggered && !order4Triggered)
            {
                order4Triggered = true;
            }
            else if (numpad3.buttonHit && order4Triggered && !order5Triggered)
            {
                order5Triggered = true;
            }
            else if (numpad9.buttonHit && order5Triggered)
            {
                numpadCorrectOrder = true;
            }
            else
            {
                // Reset all triggered orders if a wrong button is pressed
                order1Triggered = false;
                order2Triggered = false;
                order3Triggered = false;
                order4Triggered = false;
                order5Triggered = false;
            }
        }
    }
}
