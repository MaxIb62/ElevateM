using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletController : MonoBehaviour
{
    public Material greenMaterial; // Material verde
    public Material redMaterial;   // Material rojo

    private Renderer tabletRenderer;
    private bool missionCompleted = false;

    private void Start()
    {
        tabletRenderer = GetComponent<Renderer>();
        tabletRenderer.material = redMaterial;
    }

    public void SetMissionStatus(bool completed)
    {
        missionCompleted = completed;
        if (missionCompleted)
        {
            tabletRenderer.material = greenMaterial;
        }
        else
        {
            tabletRenderer.material = redMaterial;
        }
    }
}
