using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class correctoIncorrecto : MonoBehaviour
{
    public GameObject objetoIncorrecto;
    public GameObject objetoCorrecto;
    public GameObject objetoAActivar;
    public ParticleSystem sistemaDeParticulas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == objetoIncorrecto)
        {
            // Objeto incorrecto detectado, activa el objeto deseado.
            objetoAActivar.SetActive(true);
            Debug.Log(objetoCorrecto);
        }
        else if (other.gameObject == objetoCorrecto)
        {
            // Objeto correcto detectado, activa el sistema de partículas.
            sistemaDeParticulas.Play();
            Debug.Log(objetoIncorrecto);
        }
        
        Debug.Log(objetoIncorrecto);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == objetoIncorrecto)
        {
            // Objeto incorrecto detectado, activa el objeto deseado.
            objetoAActivar.SetActive(false);
        }
    }

}
