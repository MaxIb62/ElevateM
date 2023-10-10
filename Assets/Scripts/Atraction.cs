using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atraction : MonoBehaviour
{
    public float attractionStrength = 10f;
    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 attractionDirection = (transform.position - other.transform.position).normalized;
            rb.AddForce(attractionDirection * attractionStrength, ForceMode.Force);
        }
    }
}
