using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnetpoint : MonoBehaviour
{
    public float forceFactor = 200f;

    public List<Rigidbody> rgObjects = new List<Rigidbody>();
    Transform magnetP;

    void Start()
    {
        magnetP = GetComponent<Transform>();
    }
    // Start is called before the first frame update
   void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("aaaa"))
            rgObjects.Add(other.GetComponent<Rigidbody>());

    }
    void FixedUpdate()
    {
        foreach (Rigidbody rgObj in rgObjects)
        {
            rgObj.AddForce((magnetP.position - rgObj.position) * forceFactor * Time.fixedDeltaTime);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("aaaa"))
           rgObjects.Remove(other.GetComponent<Rigidbody>());
    }
}
