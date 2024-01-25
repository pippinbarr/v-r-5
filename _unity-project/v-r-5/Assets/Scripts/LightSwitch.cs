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
        Debug.Log("Switching on. Including setting on material.");
        gameObject.GetComponent<Renderer>().material = onMaterial;
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void SwitchOff()
    {
        Debug.Log("Switching off. Including setting off material.");
        gameObject.GetComponent<Renderer>().material = offMaterial;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

}