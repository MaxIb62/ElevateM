using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{
    public float amplitud = 0.1f; 
    public float velocidad = 5f;  
    public float intervaloDeTiempo = 2f; 

    private Vector3 posicionInicial;
    private float tiempoPasadoDesdeUltimoTemblor;

    private void Start()
    {
        // Guarda la posici�n inicial del objeto.
        posicionInicial = transform.position;
        tiempoPasadoDesdeUltimoTemblor = 0f;
    }

    private void Update()
    {
        // Incrementa el tiempo transcurrido desde el �ltimo temblor.
        tiempoPasadoDesdeUltimoTemblor += Time.deltaTime;

        // Comprueba si ha pasado el intervalo de tiempo deseado.
        if (tiempoPasadoDesdeUltimoTemblor >= intervaloDeTiempo)
        {
            // Calcula el desplazamiento lateral basado en una funci�n sinusoidal.
            float desplazamientoLateral = Mathf.Sin(Time.time * velocidad) * amplitud;

            // Aplica el temblor modificando la posici�n en el eje X.
            transform.position = new Vector3(posicionInicial.x + desplazamientoLateral, posicionInicial.y, posicionInicial.z);

            // Reinicia el contador de tiempo.
            tiempoPasadoDesdeUltimoTemblor = 0f;
        }
    }
}