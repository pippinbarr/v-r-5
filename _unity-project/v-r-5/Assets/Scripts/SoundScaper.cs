using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScaper : MonoBehaviour
{
    public AudioSource brown;
    public float outdoorsPitch = 0.3f;
    public float indoorsPitch = 0.28f;
    public float outdoorsVolume = 0.5f;
    public float indoorsVolume = 0.15f;
    public Transform start;
    public Transform end;
    private float xDistance;
    private bool mixing = false;
    private GameObject player;

    void Start()
    {
        xDistance = start.position.x - end.position.x;
    }

    void Update()
    {
        if (mixing && brown)
        {
            float d = start.position.x - player.transform.position.x;
            float ratio = d / xDistance;
            brown.pitch = Mathf.Lerp(outdoorsPitch, indoorsPitch, ratio);
            brown.volume = Mathf.Lerp(outdoorsVolume, indoorsVolume, ratio);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        mixing = true;
        player = collider.gameObject;
        Debug.Log(player);
    }

    void OnTriggerExit(Collider collider)
    {
        mixing = false;
        if (brown)
        {
            // Can't do this because it will set outdoors when you enter the room :(
            // brown.pitch = outdoorsPitch;
        }
    }
}