using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalAnimacion : MonoBehaviour
{
    // Referencia al componente Animator
    private Animator anim;

    void Start()
    {
        // Obtén la referencia al componente Animator
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Verifica si la animación ha terminado
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1 && !anim.IsInTransition(0))
        {
            // Cambia a la siguiente escena (puedes ajustar el nombre de la escena)
            SceneManager.LoadScene("Menu");
        }
    }
}

