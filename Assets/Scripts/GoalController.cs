using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public int PeopleSaved;
    public int PeopleInjured;
    public int Scenario;

    public float TargetTime;
    public float TimeReached;

    public TimerController TimerController;
    public EmergencyController emergencyController;
    public PlayerController playerController;
    public CanvasController canvasController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TimeReached = TimerController.timeElapsed;
            TargetTime = emergencyController.TargetTime;
            TimerController.gameObject.SetActive(false);
            canvasController.CloseTimerCanvas();
            if (TimeReached > TargetTime)
            {
                PeopleSaved = 0;
                canvasController.OpenLossCancas1();
            }
            else
            {
                Scenario = emergencyController.Scenario;
                switch (Scenario)
                {
                    case 1:
                        PeopleSaved = 1;
                        canvasController.OpenVictoryCancas1();
                        break;
                    case 2:
                        if (playerController.CarType == PlayerController.CarTypes.BIKE)
                        {
                            PeopleSaved = 0;
                            canvasController.OpenLossCancas2();
                        }
                        else
                        {
                            PeopleSaved = 1;
                            canvasController.OpenVictoryCancas1();
                        }
                        break;
                    case 3:
                        if (playerController.CarType == PlayerController.CarTypes.BIKE)
                        {
                            PeopleSaved = 0;
                            canvasController.OpenLossCancas2();
                        }
                        else if (playerController.CarType == PlayerController.CarTypes.CAR)
                        {
                            PeopleSaved = 1;
                            canvasController.OpenLossCancas2();
                        }
                        else
                        {
                            PeopleSaved = 5;
                            canvasController.OpenVictoryCancas2();
                        }
                        break;

                }
            }
        }
    }
}
