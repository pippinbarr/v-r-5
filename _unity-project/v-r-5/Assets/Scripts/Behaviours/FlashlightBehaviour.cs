using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightBehaviour : LightBehaviour
{
    public Renderer fixture;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    override public void StartBehaviour()
    {
        fixture.enabled = true;
    }

    override public void StopBehaviour()
    {
        fixture.enabled = false;
    }
}

