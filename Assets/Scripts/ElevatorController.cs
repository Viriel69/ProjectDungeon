using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    float dirY;
    [SerializeField, Range(0, 10)] private float speed = 2.0f;
    bool moveingUp = true;

    void Update()
    {
        MoveEl();
    }

    void MoveEl() 
    {
        if (transform.position.y > 7f)
        {
            moveingUp = false;
        }

        if (transform.position.y < -13f)
        {
            moveingUp = true;
        }

        if (moveingUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }

        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
    }
}
