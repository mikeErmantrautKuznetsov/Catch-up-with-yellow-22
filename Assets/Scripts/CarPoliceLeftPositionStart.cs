using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPoliceLeftPositionStart : MonoBehaviour
{
    private int poolCount = 6;
    //private bool autoExpand = false;
    [SerializeField]private CarLeftScriptPolice prefabCarLeft;

    private PoolObjects<CarLeftScriptPolice> pool;

    private void Awake()
    {
        this.pool = new PoolObjects<CarLeftScriptPolice>(this.prefabCarLeft, this.poolCount, this.transform);
        //this.pool.autoExpend = this.autoExpand;
    }

    private void Start()
    {
        InvokeRepeating("CreatePrefab", 5, 8);
    }

    private void CreatePrefab()
    {
        var spawnPosition = transform.position;
        var shit = this.pool.GetFreeElement();
        shit.transform.position = spawnPosition;
    }

    IEnumerator CreateSpawnCarRigth()
    {
        CreatePrefab();
        yield return new WaitForSeconds(5);
    }
}
