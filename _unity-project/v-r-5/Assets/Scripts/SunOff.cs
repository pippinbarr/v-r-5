using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunOff : MonoBehaviour
{
    public GameObject sun;

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
        sun.SetActive(false);
    }

    void OnTriggerExit()
    {
        sun.SetActive(true);
    }
}
