using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovePolice : MonoBehaviour
{
    private float speedCarPolice = 6f;
    private float rangeZ = 75f;
    public Transform carTransform;

    public void DisableChilds()
    {
        for (int i = 0; i < carTransform.childCount; i++)
        {
            carTransform.GetChild(i).gameObject.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.back * speedCarPolice * Time.fixedDeltaTime);

        if (transform.position.z <= -rangeZ)
        {
            gameObject.SetActive(false);
            DisableChilds();
        }

    }

}
