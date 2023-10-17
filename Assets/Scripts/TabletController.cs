using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabletController : MonoBehaviour
{
    public Toggle missionToggle;

    private void Start()
    {
        missionToggle.isOn = false;
    }

    public void SetMissionStatus(bool completed)
    {
        missionToggle.isOn = completed;
    }
}
