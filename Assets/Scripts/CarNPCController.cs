using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarNPCController : MonoBehaviour
{
    public GameObject DollyCart;
    private Vector2 _oldPosition;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        _oldPosition = transform.position;
        transform.position = DollyCart.transform.position;

        

        float deltaX = transform.position.x - _oldPosition.x;
        float deltaY = transform.position.y - _oldPosition.y;

        if(deltaX == 0)
        {
            transform.eulerAngles = Vector3.zero;
            return;
        }

        float angle = Mathf.Atan2(deltaY, deltaX);
        transform.eulerAngles = new Vector3(0, 0, angle * Mathf.Rad2Deg - 90);

    }
}
