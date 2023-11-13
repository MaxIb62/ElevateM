using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    public ParticleSystem sistemaDeParticulas;
    private bool objetoCorrectoColocado = false;

    private void Start()
    {
        if (sistemaDeParticulas == null)
        {
            Debug.LogError("Asigna el Sistema de Part�culas en el Inspector.");
        }
        else
        {
            sistemaDeParticulas.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjetoCorrecto") && !objetoCorrectoColocado)
        {
            objetoCorrectoColocado = true;
            sistemaDeParticulas.Play();
        }
        else if (other.CompareTag("ObjetoIncorrecto"))
        {
            // C�digo para activar otro objeto
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ObjetoCorrecto") && objetoCorrectoColocado)
        {
            objetoCorrectoColocado = false;
            sistemaDeParticulas.Stop();
        }
        else if (other.CompareTag("ObjetoIncorrecto"))
        {
            // C�digo para desactivar el otro objeto
        }
    }

    // Puedes agregar el siguiente m�todo para manejar la l�gica basada en el nombre del objeto.
    private void CheckObjectName(Collider other)
    {
        string nombreObjeto = other.gameObject.name;

        if (nombreObjeto == "NombreObjetoCorrecto" && !objetoCorrectoColocado)
        {
            objetoCorrectoColocado = true;
            sistemaDeParticulas.Play();
        }
        else if (nombreObjeto == "NombreObjetoIncorrecto")
        {
            // C�digo para activar otro objeto
        }
    }
}



