using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationBehaviour : LightBehaviour
{
    // The two positions to move between
    // Always moves to positionA first then alternates
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
        halfway = Vector3.Lerp(positionA.position, positionB.position, 0.5f);
        distance = Vector3.Distance(positionA.position, positionB.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToHalfway = Vector3.Distance(transform.position, halfway);
        float ratioToHalfway = distanceToHalfway / (distance / 2);
        float easedSpeed = Mathf.Lerp(speed, speed / 10, ratioToHalfway);
        transform.position = Vector3.MoveTowards(transform.position, target.position, easedSpeed);
        if (Vector3.Distance(transform.position, target.position) < 0.05f)
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

