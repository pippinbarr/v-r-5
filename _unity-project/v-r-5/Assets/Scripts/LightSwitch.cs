using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject[] Lights;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Lights go on on enter
    void OnTriggerEnter()
    {
        for (int i = 0; i < Lights.Length; i++)
        {
            Lights[i].SetActive(true);
        }
    }

    // Lights go off on exit
    void OnTriggerExit()
    {
        for (int i = 0; i < Lights.Length; i++)
        {
            Lights[i].SetActive(false);
        }
    }
}
