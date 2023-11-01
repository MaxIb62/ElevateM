using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    public ParticleSystem sistemaDeParticulas;

    private void Start()
    {
        if (sistemaDeParticulas == null)
        {
            Debug.LogError("Asigna el Sistema de Partículas en el Inspector.");
        }
        else
        {
            sistemaDeParticulas.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("aaaa"))
        {
            sistemaDeParticulas.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("aaaa"))
        {
            sistemaDeParticulas.Stop();
        }
    }
}
