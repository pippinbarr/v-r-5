using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSunTo : MonoBehaviour
{
    public Vector3 target;
    public SunController sunController;


    void OnTriggerEnter()
    {
        sunController.SetTarget(target);
    }

    void OnTriggerExit()
    {
        sunController.UnsetTarget();
    }
}