using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiadorDeEscena : MonoBehaviour
{
    // Define el �ndice de la escena a la que quieres cambiar
    public int indiceDeEscena;

    // Llama a esta funci�n cuando se presiona el bot�n
    public void CambiarEscena()
    {
        // Cambia a la escena con el �ndice especificado
        SceneManager.LoadScene(indiceDeEscena);
    }
}

