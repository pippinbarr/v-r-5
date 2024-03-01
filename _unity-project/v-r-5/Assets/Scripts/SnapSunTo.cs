using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapSunTo : MonoBehaviour
{
    public Vector3 target;
    public Transform sun;
    public AudioClip onSound;
    public AudioClip offSound;
    public AudioSource audioSource;
    private Vector3 origin;

    void Start()
    {
        origin = sun.eulerAngles;
    }

    void OnTriggerEnter()
    {
        sun.eulerAngles = target;
        audioSource.clip = onSound;
        audioSource.Play();
    }

    void OnTriggerExit()
    {
        sun.eulerAngles = origin;
        audioSource.clip = offSound;
        audioSource.Play();
    }
}