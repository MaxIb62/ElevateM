using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectZone3 : MonoBehaviour { 

    public GameObject correctImage;
    public GameObject incorrectImage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ZC3"))
        {
            ShowCorrectImage();
        }
        else if (other.CompareTag("ZI3"))
        {
            ShowIncorrectImage();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ZC3") || other.CompareTag("ZI3"))
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


