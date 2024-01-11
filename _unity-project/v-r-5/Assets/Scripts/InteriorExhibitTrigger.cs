using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriorExhibitTrigger : MonoBehaviour
{
    public GameObject[] lightFixtures;


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
        for (int i = 0; i < lightFixtures.Length; i++)
        {
            lightFixtures[i].GetComponent<LightSwitch>().SwitchOn();
            lightFixtures[i].GetComponent<LightBehaviour>().StartBehaviour();
        }
    }

    // Lights go off on exit
    void OnTriggerExit()
    {
        for (int i = 0; i < lightFixtures.Length; i++)
        {
            lightFixtures[i].GetComponent<LightSwitch>().SwitchOff();
            lightFixtures[i].GetComponent<LightBehaviour>().StopBehaviour();
        }
    }
}
