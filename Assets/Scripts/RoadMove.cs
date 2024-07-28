using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{
    private float speedRoad = 7f;
    private int repeatRoad = 141;
    private int pointStart = 0;

    private void Update()
    {
        transform.Translate(Vector3.back * speedRoad * Time.deltaTime);
        Bounce();
    }

    private void Bounce()
    {
        if (transform.position.z < -repeatRoad)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, pointStart);
        }
    }
}
