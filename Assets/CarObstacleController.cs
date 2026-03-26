using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarObstacleController : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public List<Sprite> SpriteList;

    void Start()
    {
        int rand = Random.Range(0, SpriteList.Count - 1);
        SpriteRenderer.sprite = SpriteList[rand];
    }

   
}
