using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Target;

    private void FixedUpdate()
    {
        transform.position = Player.transform.position;

        if(Target != null )
        {
            float deltaX = Target.transform.position.x - Player.transform.position.x;
            float deltaY = Target.transform.position.y - Player.transform.position.y;
            float angle = Mathf.Atan2(deltaY, deltaX);

            transform.rotation = Quaternion.Euler(0, 0, angle * Mathf.Rad2Deg + 270);

        }
    }
}
