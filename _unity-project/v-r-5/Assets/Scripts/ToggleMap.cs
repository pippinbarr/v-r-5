using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMap : MonoBehaviour
{
    public GameObject map;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        map.SetActive(!map.activeSelf);
    }

    public void Disable()
    {
        map.SetActive(false);
    }

}
