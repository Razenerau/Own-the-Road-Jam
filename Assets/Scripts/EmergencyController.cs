using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyController : MonoBehaviour
{
    public GameObject BikeMessage;
    public GameObject CarMessage;
    public GameObject VanMessage;

    public float BikeTimer = 120;
    public float CarTimer = 200;
    public float VanTimer = 400;
    public float TargetTime;

    public int Scenario;

    private void Awake()
    {
        Scenario = Random.Range(1, 4);   // returns 1, 2, or 3

        switch (Scenario)
        {
            case 1:
                BikeMessage.SetActive(true);
                TargetTime = BikeTimer;
                break;
            case 2:
                CarMessage.SetActive(true);
                TargetTime = CarTimer;
                break;
            case 3:
                VanMessage.SetActive(true);
                TargetTime = VanTimer;
                break;
        }
    }


}
