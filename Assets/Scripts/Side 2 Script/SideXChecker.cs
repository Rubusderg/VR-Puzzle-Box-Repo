using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideXChecker : MonoBehaviour
{
    [SerializeField] public Transform chip1;
    [SerializeField] public Transform chip2;
    [SerializeField] public Transform chip3;
    [SerializeField] public Transform chip4;
    [SerializeField] public Transform chip5;
    [SerializeField] public Transform chip6;
    [SerializeField] public Transform chip7;
    [SerializeField] public Transform chip8;
    [SerializeField] public Transform chip9;

    [SerializeField] public Transform chipA;
    [SerializeField] public Transform chipB;
    [SerializeField] public Transform chipC;
    [SerializeField] public Transform chipD;
    [SerializeField] public Transform chipE;
    [SerializeField] public Transform chipF;
    [SerializeField] public Transform chipG;
    [SerializeField] public Transform chipH;
    [SerializeField] public Transform chipI;   

    public bool sideXOpen = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool condition1 = (chip1.rotation.x < 0f && chip2.rotation.x > 0f && chip3.rotation.x > 0f &&
                        chip4.rotation.x < 0f && chip5.rotation.x < 0f && chip6.rotation.x > 0f &&
                        chip7.rotation.x > 0f && chip8.rotation.x < 0f && chip9.rotation.x < 0f);

        bool condition2 = (chip1.rotation.x > 0f && chip2.rotation.x < 0f && chip3.rotation.x < 0f &&
                        chip4.rotation.x > 0f && chip5.rotation.x > 0f && chip6.rotation.x < 0f &&
                        chip7.rotation.x < 0f && chip8.rotation.x > 0f && chip9.rotation.x > 0f);

        bool condition3 = (chipA.rotation.x < 0f && chipB.rotation.x > 0f && chipC.rotation.x < 0f &&
                        chipD.rotation.x > 0f && chipE.rotation.x < 0f && chipF.rotation.x > 0f &&
                        chipG.rotation.x < 0f && chipH.rotation.x < 0f && chipI.rotation.x > 0f);

        bool condition4 = (chipA.rotation.x > 0f && chipB.rotation.x < 0f && chipC.rotation.x > 0f &&
                        chipD.rotation.x < 0f && chipE.rotation.x > 0f && chipF.rotation.x < 0f &&
                        chipG.rotation.x > 0f && chipH.rotation.x > 0f && chipI.rotation.x < 0f);

        if ((condition1 || condition2) && (condition3 || condition4))
        {
            sideXOpen = true;
        }
    }
}
