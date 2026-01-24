using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject EmergencyCanvas;
    public GameObject MapCanvas;
    public GameObject SelectCanvas;
    public GameObject TimerCanvas;

    public void OpenEmergencyCancas()
    {
        EmergencyCanvas.SetActive(true);
        MapCanvas.SetActive(false);
        SelectCanvas.SetActive(false);
    }

    public void OpenMapCancas()
    {
        EmergencyCanvas.SetActive(false);
        MapCanvas.SetActive(true);
        SelectCanvas.SetActive(false);
    }

    public void OpenSelectCancas()
    {
        EmergencyCanvas.SetActive(false);
        MapCanvas.SetActive(false);
        SelectCanvas.SetActive(true);
    }
}
