using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriorExhibitTrigger : MonoBehaviour
{
    public GameObject[] fixtureParents;

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
        foreach (GameObject fixtureParent in fixtureParents)
        {
            if (fixtureParent.GetComponent<LightSwitch>())
            {
                fixtureParent.GetComponent<LightSwitch>().SwitchOn();
            }
            fixtureParent.GetComponent<LightBehaviour>().enabled = true;
            fixtureParent.GetComponent<LightBehaviour>().StartBehaviour();

        }
    }

    // Lights go off on exit
    void OnTriggerExit()
    {
        for (int i = 0; i < fixtureParents.Length; i++)
        {
            if (fixtureParents[i].GetComponent<LightSwitch>())
            {
                fixtureParents[i].GetComponent<LightSwitch>().SwitchOff();
            }
            fixtureParents[i].GetComponent<LightBehaviour>().StopBehaviour();
            fixtureParents[i].GetComponent<LightBehaviour>().enabled = false;
        }
    }
}
