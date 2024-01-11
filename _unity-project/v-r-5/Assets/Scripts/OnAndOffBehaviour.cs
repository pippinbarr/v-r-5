using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAndOffBehaviour : LightBehaviour
{
    public LightSwitch lightSwitch;
    public int onTime = 2;
    public int offTime = 2;
    private Coroutine stepRoutine;
    private bool coroutineStopped = false;

    void Start()
    {

    }

    public override void StartBehaviour()
    {
        stepRoutine = StartCoroutine(Step());
        Debug.Log("Starting coroutine");
    }

    public override void StopBehaviour()
    {
        Debug.Log("Stopping coroutine.");
        StopCoroutine(stepRoutine);
    }

    IEnumerator Step()
    {
        lightSwitch.SwitchOn();

        yield return new WaitForSeconds(onTime);

        lightSwitch.SwitchOff();

        yield return new WaitForSeconds(offTime);

        StartBehaviour();
    }


}

