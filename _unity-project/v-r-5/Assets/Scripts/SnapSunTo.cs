using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapSunTo : MonoBehaviour
{
    public Vector3 target;
    public Transform sun;
    private Vector3 origin;

    void Start()
    {
        origin = sun.eulerAngles;
    }

    void OnTriggerEnter()
    {
        sun.eulerAngles = target;
    }

    void OnTriggerExit()
    {
        sun.eulerAngles = origin;
    }
}