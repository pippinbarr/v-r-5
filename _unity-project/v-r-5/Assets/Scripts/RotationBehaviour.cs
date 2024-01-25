using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBehaviour : LightBehaviour
{
    // The two localEulerAngless to move between
    // Always rotates to positionA first then alternates
    public Transform positionA;
    public Transform positionB;
    public float speed = 0.1f; // In units per second
    private Transform target;
    private float distance;
    private Vector3 halfway;

    // Start is called before the first frame update
    void Start()
    {
        target = positionA;
        halfway = Vector3.Lerp(positionA.localEulerAngles, positionB.localEulerAngles, 0.5f);
        distance = Vector3.Distance(positionA.localEulerAngles, positionB.localEulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToHalfway = Vector3.Distance(transform.localEulerAngles, halfway);
        float ratioToHalfway = distanceToHalfway / (distance / 2);
        float easedSpeed = Mathf.Lerp(speed, speed / 10, ratioToHalfway);
        transform.localEulerAngles = Vector3.MoveTowards(transform.localEulerAngles, target.localEulerAngles, easedSpeed);
        Debug.Log(Vector3.Distance(transform.localEulerAngles, target.localEulerAngles));
        if (Vector3.Distance(transform.localEulerAngles, target.localEulerAngles) < easedSpeed)
        {
            if (target == positionA)
            {
                target = positionB;
            }
            else
            {
                target = positionA;
            }
        }
    }

    public override void StartBehaviour()
    {

    }

    public override void StopBehaviour()
    {

    }
}

