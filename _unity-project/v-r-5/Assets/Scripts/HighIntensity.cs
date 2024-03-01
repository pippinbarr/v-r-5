using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighIntensity : MonoBehaviour
{
    public GameObject sun;
    public float intensity = 500f;
    private float starting;

    // Start is called before the first frame update
    void Start()
    {
        starting = sun.GetComponent<Light>().intensity;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        sun.GetComponent<Light>().intensity = intensity;
    }

    void OnTriggerExit()
    {
        sun.GetComponent<Light>().intensity = starting;
    }
}
