using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour
{
    public float RotX;
    public float RotY;
    public float RotZ;
    public float speed = 30;
    void Update()
    {
        transform.Rotate(RotX * Time.deltaTime * speed, RotY * Time.deltaTime * speed, RotZ * Time.deltaTime, Space.World);
    }
}
