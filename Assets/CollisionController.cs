using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public GoalController gameController;
    public static int peopleInjured;
    public GameObject floatingTextPrefab;
    public GameObject ParticleCanvas;

    [Header("SFX")]
    public List<AudioClip> HitPersonList;
    public List<AudioClip> HitCarList;
    public AudioClip HitWall;

    public static CollisionController Instance;

    private void Awake()
    {
        peopleInjured = 0;

        if (Instance == null)
        Instance = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "People")
        {
            collision.gameObject.SetActive(false);
            peopleInjured++;

            ShowFloatingNumber(collision.gameObject, 1, ParticleCanvas.transform);  

            SFXManager.Instance.PlaySFX(HitPersonList, transform, 1f);
        }

        if(collision.gameObject.tag == "Cars")
        {
            collision.gameObject.SetActive(false);

            int pplInjured = Random.Range(1, 4);

            peopleInjured += pplInjured;

            ShowFloatingNumber(collision.gameObject, pplInjured, ParticleCanvas.transform);

            SFXManager.Instance.PlaySFX(HitCarList, transform, 0.7f);
        }

        if (collision.gameObject.tag == "Walls")
        {
            SFXManager.Instance.PlaySFX(HitWall, transform, 1f);
        }
    }

    

    public void ShowFloatingNumber(GameObject target, int number, Transform t)
    {
        // Position above object
        Vector3 spawnPos = target.transform.position + Vector3.up * 2f;

        // Instantiate
        GameObject obj = Instantiate(floatingTextPrefab, spawnPos, Quaternion.identity);
        obj.transform.SetParent(t);

        // Set number text
        FloatingText ft = obj.GetComponent<FloatingText>();
        ft.SetText("-" + number.ToString());
    }
}
