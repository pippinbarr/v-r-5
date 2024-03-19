using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerReset : MonoBehaviour
{
    public Transform start;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown("/"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}