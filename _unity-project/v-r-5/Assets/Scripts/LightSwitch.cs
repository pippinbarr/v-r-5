using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Material onMaterial;
    public Material offMaterial;
    public GameObject fixture;
    public AudioClip onSound;
    public AudioClip offSound;
    public AudioSource lightClickSource;

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
        lightClickSource.clip = onSound;
        lightClickSource.Play();
    }

    public void SwitchOff()
    {
        if (fixture.transform.GetChild(0).gameObject.activeSelf)
        {
            lightClickSource.clip = offSound;
            lightClickSource.Play();
        }
        fixture.GetComponent<Renderer>().material = offMaterial;
        fixture.transform.GetChild(0).gameObject.SetActive(false);
    }

}