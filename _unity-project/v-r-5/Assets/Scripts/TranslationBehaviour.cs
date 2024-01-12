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

    // Start is called before the first frame update
    void Start()
    {
        target = positionA;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
        if (Vector3.Equals(transform.position, target.position))
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
}

