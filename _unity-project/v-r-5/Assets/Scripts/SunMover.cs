using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**

Rotates the sun in the sky based on the player's position relative to the two
"poles" at the "north" and "south" of the island.

*/
public class SunMover : MonoBehaviour
{
    public float minAngle = 0;
    public float maxAngle = 225;
    public Transform sun;
    public Transform player;
    public Transform north;
    public Transform south;
    private float d;

    // Start is called before the first frame update
    void Start()
    {
        // Calculate the distance from the north to south pole (for ratio)
        d = north.position.z - south.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate how far between the poles the player is [0..1]
        float ratio = Mathf.Abs(player.position.z - south.position.z) / d;
        // Clamp it for safety
        ratio = Mathf.Clamp(ratio, 0, 1);
        // Calculate the new x rotation of the sun based on this min and max
        // angles relative to that ratio
        float angle = (maxAngle - minAngle) * ratio + minAngle;
        // Create the new rotation vector
        Vector3 newRotation = new Vector3(angle, 0, 0);
        // Apply it
        sun.eulerAngles = newRotation;
    }
}
