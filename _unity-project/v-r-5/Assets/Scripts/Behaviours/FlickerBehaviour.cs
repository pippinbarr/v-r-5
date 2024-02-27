using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerBehaviour : LightBehaviour
{
    public Light flickerer;
    public Material lightOnMaterial;
    public float min = 0f;
    public float max = 2f;
    public float interval = 1;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        lightOnMaterial.EnableKeyword("_EMISSION");
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count == interval)
        {
            float intensity = Random.Range(min, max);
            flickerer.intensity = intensity;
            lightOnMaterial.SetColor("_EmissionColor", new Color(intensity, intensity, intensity, 1f));
            count = 0;
        }
    }

    override public void StartBehaviour()
    {

    }

    override public void StopBehaviour()
    {

        lightOnMaterial.SetColor("_EmissionColor", new Color(1f, 1f, 1f, 1f));
    }
}

