using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPolice : MonoBehaviour
{
    private float rangeX = 2.9f;
    private float speedCar = 0.5f;
    private bool moveing;
    private bool moveingFail = true;
    [SerializeField]
    private GameObject sceneLoseGame;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Man"))
        {
            Time.timeScale = 0;
            moveingFail = false;
        }
    }

    private void LateUpdate()
    {
        CarMovePolice();
    }

    private void CarMovePolice()
    {
        if (moveingFail == true)
        {
            if (transform.position.x >= rangeX)
            {
                moveing = false;
            }
            if (transform.position.x <= -rangeX)
            {
                moveing = true;
            }

            if (moveing)
            {
                transform.position = new Vector3(transform.position.x + speedCar * Time.fixedDeltaTime,
                    transform.position.y, transform.position.z);
            }
            if (!moveing)
            {
                transform.position = new Vector3(transform.position.x - speedCar * Time.fixedDeltaTime,
                    transform.position.y, transform.position.z);
            }
        }
    }
}
