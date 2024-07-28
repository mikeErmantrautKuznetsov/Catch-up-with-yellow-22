using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPoliceRightPositionStart : MonoBehaviour
{
    private int poolCount = 4;
    //private bool autoExpand = false;
    
    [SerializeField]private CarRightScriptPolice prefabCarRight;

    private PoolObjects<CarRightScriptPolice> pool;

    private void Awake()
    {
        this.pool = new PoolObjects<CarRightScriptPolice>(this.prefabCarRight, this.poolCount, this.transform);
        //this.pool.autoExpend = this.autoExpand;
    }

    private void Start()
    {
        InvokeRepeating("CreatePrefab", 3, 7);
    }

    private void CreatePrefab()
    {
        var spawnPosition = transform.position;
        var shit = this.pool.GetFreeElement();
        shit.transform.position = spawnPosition;
    }

    IEnumerator CreateSpawnCarLeft()
    {
        CreatePrefab();
        yield return new WaitForSeconds(10);
    }
}
