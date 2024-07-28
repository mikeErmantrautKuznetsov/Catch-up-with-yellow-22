using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brassknuckles : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Man"))
        {
            ScoreManager.score += 1f;
            gameObject.SetActive(false);
        }
    }
}
