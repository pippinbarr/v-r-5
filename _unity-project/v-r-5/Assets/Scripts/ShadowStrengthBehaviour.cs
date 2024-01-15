using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowStrengthBehaviour : LightBehaviour
{
    // The two positions to move between
    // Always moves to positionA first then alternates
    public float min;
    public float max;
    public float speed = 0.1f; // In units per something
    private Light theLight;
    private float angle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        theLight = gameObject.transform.GetChild(0).GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed;
        float ratio = Mathf.Abs(Mathf.Sin(angle));
        float strength = Mathf.Lerp(min, max, ratio);
        theLight.shadowStrength = strength;
    }
}

