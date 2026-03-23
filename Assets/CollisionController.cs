using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public GoalController gameController;
    public static int peopleInjured;

    [Header("SFX")]
    public List<AudioClip> HitPersonList;
    public AudioClip HitWall;

    public static CollisionController Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "People" || collision.gameObject.tag == "Cars")
        {
            collision.gameObject.SetActive(false);
            peopleInjured++;

            SFXManager.Instance.PlaySFX(HitPersonList, transform, 1f);
        }
    }
}
