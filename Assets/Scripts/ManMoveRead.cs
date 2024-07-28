using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManMoveRead : MonoBehaviour
{
    private IControllbleMan controllbleMan;

    private void Awake()
    {
        controllbleMan = GetComponent<IControllbleMan>();

        if (controllbleMan == null )
        {
            throw new Exception($"There is no IControllable component on the object: {gameObject.name}");
        }
    }

    public void readControllerMan()
    {
        controllbleMan.ControllerMan();
    }
}
