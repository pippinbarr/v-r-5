using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAmbientColor : MonoBehaviour
{
    public Color toColor;
    private Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        originalColor = RenderSettings.ambientLight;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        Debug.Log("Setting ambient color");
        RenderSettings.ambientLight = toColor;
    }

    void OnTriggerExit()
    {
        RenderSettings.ambientLight = originalColor;
    }
}
