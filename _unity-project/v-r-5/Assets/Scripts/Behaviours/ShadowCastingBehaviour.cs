using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowCastingBehaviour : LightBehaviour
{
    public LightSwitch lightSwitch;
    public int onTime = 5;
    public float offTime = 0.25f;
    private Coroutine stepRoutine;
    public Renderer thePlinth;
    public Renderer theVase;


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

        if (thePlinth.shadowCastingMode == UnityEngine.Rendering.ShadowCastingMode.On)
        {
            thePlinth.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
            theVase.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        }
        else
        {
            thePlinth.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            theVase.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        }

        lightSwitch.SwitchOn();

        yield return new WaitForSeconds(onTime);

        lightSwitch.SwitchOff();

        yield return new WaitForSeconds(offTime);

        StartBehaviour();
    }


}

