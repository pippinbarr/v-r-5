using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Material onMaterial;
    public Material offMaterial;
    public GameObject fixture;

    void Start()
    {

    }
    void Update()
    {

    }

    public void SwitchOn()
    {
        fixture.GetComponent<Renderer>().material = onMaterial;
        fixture.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void SwitchOff()
    {
        fixture.GetComponent<Renderer>().material = offMaterial;
        fixture.transform.GetChild(0).gameObject.SetActive(false);
    }

}