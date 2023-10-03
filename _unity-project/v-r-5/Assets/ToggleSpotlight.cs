using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSpotlight : MonoBehaviour
{
    public GameObject spotlight;

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
        spotlight.SetActive(true);
    }

    void OnTriggerExit()
    {
        spotlight.SetActive(false);
    }
}
