using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panell : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Aseg�rate de que solo el jugador puede activar el panel
        {
            ActivatePanel();
            Invoke("DeactivatePanel", 3f);  // Desactiva el panel despu�s de 3 segundos
        }
    }

    void ActivatePanel()
    {
        panel.SetActive(true);
    }

    void DeactivatePanel()
    {
        panel.SetActive(false);
    }
}

