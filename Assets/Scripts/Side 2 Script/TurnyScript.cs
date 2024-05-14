using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TurnyScript : MonoBehaviour
{
    [SerializeField] public Transform chipToLeft;
    [SerializeField] public Transform chipToRight;
    [SerializeField] public Transform chipToBottom;
    [SerializeField] public Transform chipSelf;

    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log(transform.rotation);
        if(transform.rotation.x < 0)
        {
            Debug.Log("value lower than 0");
        }
        if(transform.rotation.x > 0)
        {
            Debug.Log("value higher than 0");
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            chipToLeft.transform.Rotate(180f, 0f, 0f);
            chipToRight.transform.Rotate(180f, 0f, 0f);
            chipToBottom.transform.Rotate(180f, 0f, 0f);
            chipSelf.transform.Rotate(180f, 0f, 0f);
        }
    }
}
