using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoCorrecto : MonoBehaviour
{
    public string tagObjeto1 = "Correct";
    public string tagObjeto2 = "incorrect";
    public GameObject objeto1;
    public GameObject objeto2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagObjeto1))
        {
            
            objeto1.SetActive(true);
            Debug.Log("correcto");
        }
        if (other.CompareTag(tagObjeto2))
        {
            objeto2.SetActive(true);
            Debug.Log("incorrecto");

        }
    }
}
