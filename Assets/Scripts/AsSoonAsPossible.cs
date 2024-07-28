using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsSoonAsPossible : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1.0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Man"))
        {
            Time.timeScale++;
        }
    }
}
