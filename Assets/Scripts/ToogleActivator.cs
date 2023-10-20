using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleActivator : MonoBehaviour
{
    public Toggle toggleToActivate;

    void OnTriggerEnter(Collider other)
    {
        if (toggleToActivate != null)
        {
            toggleToActivate.isOn = true;
        }
    }
}
