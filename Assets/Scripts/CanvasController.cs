using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public GameObject EmergencyCanvas;
    public GameObject MapCanvas;
    public GameObject SelectCanvas;
    public GameObject TimerCanvas;
    public GameObject LossCanvas1;
    public GameObject LossCanvas2;
    public GameObject VictoryCanvas1;
    public GameObject VictoryCanvas2;
    public GameObject InjuredCanvas;

    public TextMeshProUGUI InjuredText;

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

    public void OpenLossCancas1()
    {
        LossCanvas1.SetActive(true);
    }

    public void OpenLossCancas2()
    {
        LossCanvas2.SetActive(true);
    }

    public void OpenVictoryCancas1()
    {
        VictoryCanvas1.SetActive(true);
    }
    public void OpenVictoryCancas2()
    {
        VictoryCanvas2.SetActive(true);
    }

    public void CloseTimerCanvas()
    {
        TimerCanvas.SetActive(false);
    }

    public void OpenInjuredCanvas()
    {
        int peopleInjured = CollisionController.peopleInjured;
        InjuredText.text = $"{peopleInjured} People Injured";
        InjuredCanvas.SetActive(true);
    }

    public void Reload()
    {
        Scene current = SceneManager.GetActiveScene();
        SceneManager.LoadScene(current.name);
    }

}
