using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    private Transform parentTransform;
    private bool isInsideCollider = false;

    private void Start()
    {
        parentTransform = GameObject.Find("Parent").transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("estante")) // Reemplaza "ColliderTag" con la etiqueta adecuada del Collider.
        {
            isInsideCollider = true;
            transform.SetParent(parentTransform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (isInsideCollider)
        {
            isInsideCollider = false;
            transform.SetParent(null); // Quitamos al objeto de ser hijo del otro objeto.
        }
    }
}
