using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TActivator : MonoBehaviour
{
    public Toggle toggle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("elevatorbox")) 
        {
            toggle.isOn = true; // Activa el Toggle
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("elevatorbox"))
        {
            
            toggle.isOn = false;
        }
    }
}
