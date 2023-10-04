using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectZone : MonoBehaviour { 

    public GameObject correctImage;
    public GameObject incorrectImage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ZonaCorrecta"))
        {
            ShowCorrectImage();
        }
        else if (other.CompareTag("ZonaIncorrecta"))
        {
            ShowIncorrectImage();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ZonaCorrecta") || other.CompareTag("ZonaIncorrecta"))
        {
            HideImages();
        }
    }

    private void ShowCorrectImage()
    {
        correctImage.SetActive(true);
        incorrectImage.SetActive(false);
    }

    private void ShowIncorrectImage()
    {
        correctImage.SetActive(false);
        incorrectImage.SetActive(true);
    }

    private void HideImages()
    {
        correctImage.SetActive(false);
        incorrectImage.SetActive(false);
    }
}


