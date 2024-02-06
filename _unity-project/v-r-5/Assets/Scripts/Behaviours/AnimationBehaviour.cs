using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBehaviour : LightBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        animator.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    override public void StartBehaviour()
    {
        animator.speed = 1f;
    }

    override public void StopBehaviour()
    {
        animator.speed = 0f;
    }
}

