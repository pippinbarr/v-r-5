using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMove : MonoBehaviour
{
    public GameObject sun;

    private bool moving = false;
    private Quaternion start;

    // Start is called before the first frame update
    void Start()
    {
        start = sun.GetComponent<Transform>().rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            sun.transform.Rotate(0, 1, 0);
        }
    }

    void OnTriggerEnter()
    {
        moving = true;
    }

    void OnTriggerExit()
    {
        moving = false;
        sun.transform.rotation = start;
    }
}
