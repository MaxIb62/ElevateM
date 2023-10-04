using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Velocidad de movimiento del jugador

    void Update()
    {
        // Obtener las entradas del teclado
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcular la direcci�n del movimiento
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        // Normalizar la direcci�n para que el movimiento diagonal no sea m�s r�pido
        movement.Normalize();

        // Aplicar la velocidad y el tiempo para suavizar el movimiento en diferentes FPS
        movement *= speed * Time.deltaTime;

        // Mover al jugador
        transform.Translate(movement);
    }
}


