using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public string nombreDeLaEscenaACargar; // Nombre de la escena a la que quieres cambiar.

    // Puedes llamar a este método desde un botón en Unity si lo deseas.
    public void CambiarEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscenaACargar);
    }

    // También puedes usar Update() para cambiar de escena cuando se presiona un botón del teclado, por ejemplo.
    // Si deseas cambiar la escena cuando se presiona un botón específico, debes especificar el botón que desees (por ejemplo, KeyCode.Space).
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(nombreDeLaEscenaACargar);
        }
    }
}
