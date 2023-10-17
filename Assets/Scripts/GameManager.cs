using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TabletController tabletController;
    public Toggle missionToggle;
    private bool missionCompleted = false;

    private void Start()
    {
        missionToggle.isOn = false;
        tabletController.SetMissionStatus(missionToggle.isOn);
    }

    public void OnMissionToggleChanged()
    {
        missionCompleted = missionToggle.isOn;
        tabletController.SetMissionStatus(missionCompleted);
    }
}
