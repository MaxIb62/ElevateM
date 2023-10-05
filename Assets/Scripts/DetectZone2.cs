using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectZone2 : MonoBehaviour { 

    public GameObject correctImage;
    public GameObject incorrectImage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ZC2"))
        {
            ShowCorrectImage();
        }
        else if (other.CompareTag("ZI2"))
        {
            ShowIncorrectImage();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ZC2") || other.CompareTag("ZI2"))
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


