using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffTheLights : MonoBehaviour
{
    public Light[] Lights;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter() 
    {
        for (int i = 0; i < Lights.Length; i++)
        {
            Lights[i].GetComponent<Light>().enabled = false;
        }
    }
}
