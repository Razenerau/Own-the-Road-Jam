using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public GoalController gameController;
    public int peopleInjured;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "People" || collision.gameObject.tag == "Cars")
        {
            collision.gameObject.SetActive(false);
            peopleInjured++;
        }
    }
}
