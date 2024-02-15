using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowReceivingBehaviour : LightBehaviour
{
    public LightSwitch lightSwitch;
    public int onTime = 5;
    public float offTime = 0.25f;
    private Coroutine stepRoutine;
    public Renderer theBacking;


    void Start()
    {

    }

    public override void StartBehaviour()
    {
        stepRoutine = StartCoroutine(Step());
    }

    public override void StopBehaviour()
    {
        StopCoroutine(stepRoutine);
    }

    IEnumerator Step()
    {

        theBacking.receiveShadows = !theBacking.receiveShadows;

        lightSwitch.SwitchOn();

        yield return new WaitForSeconds(onTime);

        lightSwitch.SwitchOff();

        yield return new WaitForSeconds(offTime);

        StartBehaviour();
    }


}

