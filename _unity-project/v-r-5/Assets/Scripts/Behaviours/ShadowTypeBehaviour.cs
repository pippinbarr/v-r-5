using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowTypeBehaviour : LightBehaviour
{
    public LightSwitch lightSwitch;
    public int onTime = 5;
    public float offTime = 0.25f;
    private Coroutine stepRoutine;
    public Light theLight;

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
        if (theLight.shadows == LightShadows.Hard)
        {
            theLight.shadows = LightShadows.Soft;
        }
        else
        {
            theLight.shadows = LightShadows.Hard;
        }

        lightSwitch.SwitchOn();

        yield return new WaitForSeconds(onTime);

        lightSwitch.SwitchOff();

        yield return new WaitForSeconds(offTime);

        StartBehaviour();
    }


}

