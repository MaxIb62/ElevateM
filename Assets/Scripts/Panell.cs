using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panell : MonoBehaviour
{
        public string nombreObjetoInteractuable;
        public GameObject panel;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == nombreObjetoInteractuable)
            {
                panel.SetActive(true);
                Invoke("DesactivarPanel", 3f);
            }
        }

        private void DesactivarPanel()
        {
            panel.SetActive(false);
        }
}



