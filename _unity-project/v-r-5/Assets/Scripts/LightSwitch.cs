using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Material onMaterial;
    public Material offMaterial;

    void Start()
    {

    }
    void Update()
    {

    }

    public void SwitchOn()
    {
        gameObject.GetComponent<Renderer>().material = onMaterial;
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void SwitchOff()
    {
        gameObject.GetComponent<Renderer>().material = offMaterial;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

}