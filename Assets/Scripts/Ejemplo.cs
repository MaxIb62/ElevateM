using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{
    public TabletController tablet; // Asigna el objeto de la "tablet" en el Inspector de Unity

    // Aquí puedes tener lógica para determinar si la misión se ha completado o no.
    private bool missionCompleted = false;

    private void Update()
    {
        // Supongamos que en algún punto determinas si la misión se ha completado.
        // Puedes cambiar esto según la lógica de tu juego.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            missionCompleted = !missionCompleted; // Simulamos un cambio de estado de la misión al presionar la barra espaciadora.
            tablet.SetMissionStatus(missionCompleted);
        }
    }
}
