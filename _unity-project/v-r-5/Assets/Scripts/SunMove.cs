using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMove : MonoBehaviour
{
    public GameObject sun;
    public Vector3 speed = new Vector3(1, 0, 0);

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
            Debug.Log("Moving...");
            sun.transform.Rotate(speed.x, speed.y, speed.z, Space.World);
        }
    }

    void OnTriggerEnter()
    {
        Debug.Log("Sun Mover Trigger!");
        moving = true;
    }

    void OnTriggerExit()
    {
        moving = false;
        sun.transform.rotation = start;
    }
}
