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

    public int EmergencyNumber;

    private void Awake()
    {
        EmergencyNumber = Random.Range(1, 4);   // returns 1, 2, or 3

        switch (EmergencyNumber)
        {
            case 1:
                BikeMessage.SetActive(true);
                break;
            case 2:
                CarMessage.SetActive(true);
                break;
            case 3:
                VanMessage.SetActive(true);
                break;
        }
    }
}
