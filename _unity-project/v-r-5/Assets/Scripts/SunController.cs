using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{
    public Transform sun;
    public float speed = 0.2f;

    private Vector3 origin;
    private Vector3 target;

    void Start()
    {
        origin = sun.transform.eulerAngles;
        target = origin;
    }

    void Update()
    {
        if (sun.transform.eulerAngles != target)
        {
            sun.transform.eulerAngles = Vector3.MoveTowards(sun.transform.eulerAngles, target, speed);
        }
    }

    public void SetTarget(Vector3 rotation)
    {
        target = rotation;
    }

    public void UnsetTarget()
    {
        target = origin;
    }
}