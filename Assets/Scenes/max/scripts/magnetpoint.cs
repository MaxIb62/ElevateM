using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnetpoint : MonoBehaviour
{
    public float forceFactor = 200f;
    public List<string> tagsToAttract = new List<string>();
    public List<Rigidbody> rgObjects = new List<Rigidbody>();
    Transform magnetP;

    void Start()
    {
        magnetP = GetComponent<Transform>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (tagsToAttract.Contains(other.tag))
        {
            Rigidbody rgObj = other.GetComponent<Rigidbody>();
            if (rgObj != null)
            {
                rgObjects.Add(rgObj);
            }
        }
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
        if (tagsToAttract.Contains(other.tag))
        {
            Rigidbody rgObj = other.GetComponent<Rigidbody>();
            if (rgObj != null)
            {
                rgObjects.Remove(rgObj);
            }
        }
    }
}
