using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriorExhibitTrigger : MonoBehaviour
{
    public GameObject[] fixtureParents;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < fixtureParents.Length; i++)
        {
            fixtureParents[i].GetComponent<Animator>().speed = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Lights go on on enter
    void OnTriggerEnter()
    {
        for (int i = 0; i < fixtureParents.Length; i++)
        {
            fixtureParents[i].GetComponent<LightSwitch>().SwitchOn();
            fixtureParents[i].GetComponent<Animator>().speed = 1f;
            // fixtureParents[i].GetComponent<LightBehaviour>().enabled = true;
            // fixtureParents[i].GetComponent<LightBehaviour>().StartBehaviour();
        }
    }

    // Lights go off on exit
    void OnTriggerExit()
    {
        for (int i = 0; i < fixtureParents.Length; i++)
        {
            fixtureParents[i].GetComponent<LightSwitch>().SwitchOff();
            fixtureParents[i].GetComponent<Animator>().speed = 0f;

            // fixtureParents[i].GetComponent<LightSwitch>().SwitchOff();
            // fixtureParents[i].GetComponent<LightBehaviour>().StopBehaviour();
            // fixtureParents[i].GetComponent<LightBehaviour>().enabled = false;
        }
    }
}
