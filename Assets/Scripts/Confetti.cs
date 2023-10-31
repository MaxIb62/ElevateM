using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    public GameObject sistemaDeParticulas;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("toggle"))
        {
            if (sistemaDeParticulas != null)
            {
                sistemaDeParticulas.SetActive(true);
            }
        }
    }
}
