using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MapChecker : MonoBehaviour
{
    public GameObject dot;
    public Color visitedColor;

    // Start is called before the first frame update
    void Start()
    {
        // dot.GetComponent<TextMeshPro>().color = unvisitedColor;
    }

    public void OnTriggerEnter()
    {
        // Change the dot over
        dot.GetComponent<TMP_Text>().color = visitedColor;
    }


}
