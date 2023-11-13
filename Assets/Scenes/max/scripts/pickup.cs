using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject correcto;
    public GameObject incorrecto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Correct"))
        {
            correcto.SetActive(true);
        }
      /*  else if (other.CompareTag("correct"))
        {
            incorrecto.SetActive(true);
        }*/
    }
   /* public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collider.SetActive(true);
        }
    }*/
}
