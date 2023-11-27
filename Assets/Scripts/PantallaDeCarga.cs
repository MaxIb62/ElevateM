using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class PantallaDeCarga : MonoBehaviour
{
    public Slider barraDeProgreso;
    public TMP_Text textoProgreso;

    void Start()
    {
        // Inicia la carga asíncrona de la escena deseada
        StartCoroutine(CargarEscenaAsincrona("EscenaPrincipal"));
    }

    System.Collections.IEnumerator CargarEscenaAsincrona(string nombreDeEscena)
    {
        AsyncOperation operacionCarga = SceneManager.LoadSceneAsync(nombreDeEscena);

        while (!operacionCarga.isDone)
        {
            // Calcula el progreso de carga (entre 0 y 1)
            float progreso = Mathf.Clamp01(operacionCarga.progress / 0.9f);

            // Actualiza la barra de progreso y el texto
            barraDeProgreso.value = progreso;
            textoProgreso.text = "Cargando... " + (int)(progreso * 100) + "%";

            yield return null; // Espera un frame
        }
    }
}

