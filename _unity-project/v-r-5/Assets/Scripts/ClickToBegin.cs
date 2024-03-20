using System.Collections;
using System.Collections.Generic;
using Hertzole.GoldPlayer;
using UnityEngine;

public class ClickToBegin : MonoBehaviour
{
    public GoldPlayerController player;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            player.enabled = true;
            gameObject.SetActive(false);
        }
    }


}