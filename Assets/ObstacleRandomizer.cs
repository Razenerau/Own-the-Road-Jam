using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRandomizer : MonoBehaviour
{
    public float Chance = 0.33333f;
    void Start()
    {
        float rand = Random.value;
        if (rand > Chance) 
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);
    }
}
