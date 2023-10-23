using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    private Transform parentTransform;
    private bool isInsideCollider = false;

    private void Start()
    {
        parentTransform = GameObject.Find("Cube").transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("elevator")) // Reemplaza "ColliderTag" con la etiqueta adecuada del Collider.
        {
            isInsideCollider = true;
            transform.SetParent(parentTransform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (isInsideCollider)
        {
            isInsideCollider = false;
            transform.SetParent(null); // Quitamos al objeto de ser hijo del otro objeto.
        }
    }
}
