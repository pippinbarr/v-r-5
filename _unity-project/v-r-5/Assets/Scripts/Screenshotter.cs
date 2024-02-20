using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshotter : MonoBehaviour
{
    private int counter = 0;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("\\"))
        {
            ScreenCapture.CaptureScreenshot("screenshot-" + counter + ".png", 1);
            counter++;
        }
    }
}