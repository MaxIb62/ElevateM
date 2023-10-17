using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{
    public TabletController tablet; // Asigna el objeto de la "tablet" en el Inspector de Unity

    // Aqu� puedes tener l�gica para determinar si la misi�n se ha completado o no.
    private bool missionCompleted = false;

    private void Update()
    {
        // Supongamos que en alg�n punto determinas si la misi�n se ha completado.
        // Puedes cambiar esto seg�n la l�gica de tu juego.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            missionCompleted = !missionCompleted; // Simulamos un cambio de estado de la misi�n al presionar la barra espaciadora.
            tablet.SetMissionStatus(missionCompleted);
        }
    }
}
