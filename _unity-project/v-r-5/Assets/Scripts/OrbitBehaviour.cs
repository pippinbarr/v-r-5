using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitBehaviour : LightBehaviour
{
    public GameObject rotationParent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotationParent.transform.Rotate(0.0f, 0.0f, 0.25f);
    }
}

