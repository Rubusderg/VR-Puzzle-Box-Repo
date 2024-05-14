using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyActivation : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public ChessPieceMove queenCheck;
    private bool hasHappened = false;

    public FinalSideKeyCheck finalSideKeyCheck;

    void Start()
    {
        // Get the MeshRenderer component attached to the GameObject
        meshRenderer = GetComponent<MeshRenderer>();

        // Deactivate the MeshRenderer at the start
        meshRenderer.enabled = false;
    }

    void Update()
    {
        if(queenCheck.isKey && !hasHappened)
        {
            // Activate the MeshRenderer on proper positioning of Queen
            meshRenderer.enabled = true;
            hasHappened = true;
        }

        if(finalSideKeyCheck.isOpen)
        {
            Destroy(gameObject);
        }
    }
}
