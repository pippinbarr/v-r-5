using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalLightBehaviour : LightBehaviour
{
    public Transform sun;
    public Vector3 target = new Vector3(175, 395, 0);
    private Vector3 origin;

    void Start()
    {

    }

    public override void StartBehaviour()
    {
        origin = sun.eulerAngles;
        sun.eulerAngles = target;
    }

    public override void StopBehaviour()
    {
        sun.eulerAngles = origin;
    }

    void Update()
    {

    }
}

