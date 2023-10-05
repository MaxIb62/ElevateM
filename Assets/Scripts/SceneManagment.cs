using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public string nombreDeLaEscenaACargar; // Nombre de la escena a la que quieres cambiar.

    // Puedes llamar a este m�todo desde un bot�n en Unity si lo deseas.
    public void CambiarEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscenaACargar);
    }

    // Tambi�n puedes usar Update() para cambiar de escena cuando se presiona un bot�n del teclado, por ejemplo.
    // Si deseas cambiar la escena cuando se presiona un bot�n espec�fico, debes especificar el bot�n que desees (por ejemplo, KeyCode.Space).
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(nombreDeLaEscenaACargar);
        }
    }
}
