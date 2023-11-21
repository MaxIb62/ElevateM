using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiadorDeEscena : MonoBehaviour
{
    // Define el índice de la escena a la que quieres cambiar
    public int indiceDeEscena;

    // Llama a esta función cuando se presiona el botón
    public void CambiarEscena()
    {
        // Cambia a la escena con el índice especificado
        SceneManager.LoadScene(indiceDeEscena);
    }
}

