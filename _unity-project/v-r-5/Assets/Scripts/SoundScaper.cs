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
    private float mixZoneLength;
    private bool mixing = false;
    private GameObject player;

    void Start()
    {
        mixZoneLength = Vector3.Distance(start.position, end.position);
    }

    void Update()
    {
        if (mixing && brown)
        {
            float playerDistance = Vector3.Distance(player.transform.position, start.position);
            float ratio = playerDistance / mixZoneLength;
            // Debug.Log(ratio);
            brown.pitch = Mathf.Lerp(outdoorsPitch, indoorsPitch, ratio);
            brown.volume = Mathf.Lerp(outdoorsVolume, indoorsVolume, ratio);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        mixing = true;
        player = collider.gameObject;
        // Debug.Log("Pitch: " + brown.pitch + ", Volume: " + brown.volume);
    }

    void OnTriggerExit(Collider collider)
    {
        mixing = false;
        // Debug.Log("Pitch: " + brown.pitch + ", Volume: " + brown.volume);

        if (brown)
        {
            float playerEndDistance = Vector3.Distance(player.transform.position, end.position);
            float playerStartDistance = Vector3.Distance(player.transform.position, start.position);
            // Can't do this because it will set outdoors when you enter the room :(
            if (playerStartDistance < playerEndDistance)
            {
                // Debug.Log("Outdoors.");
                brown.pitch = outdoorsPitch;
                brown.volume = outdoorsVolume;
            }
            else
            {
                // Debug.Log("Indoors.");
                brown.pitch = indoorsPitch;
                brown.volume = indoorsVolume;

            }
        }
    }
}