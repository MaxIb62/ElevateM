using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class correctoIncorrecto : MonoBehaviour
{
    public List<GameObject> objetosIncorrectos;
    public GameObject objetoCorrecto;
    public GameObject objetoAActivar;
    public ParticleSystem sistemaDeParticulas;

    private void OnTriggerEnter(Collider other)
    {
        if (objetosIncorrectos.Contains(other.gameObject))
        {
            // Objeto incorrecto detectado, activa el objeto deseado.
            objetoAActivar.SetActive(true);
            Debug.Log("Objeto incorrecto detectado: " + other.gameObject.name);
        }
        else if (other.gameObject == objetoCorrecto)
        {
            // Objeto correcto detectado, activa el sistema de partículas.
            sistemaDeParticulas.Play();
            Debug.Log("Objeto correcto detectado: " + other.gameObject.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (objetosIncorrectos.Contains(other.gameObject))
        {
            // Objeto incorrecto detectado, desactiva el objeto deseado.
            objetoAActivar.SetActive(false);
        }
    }
}

