using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    // Update is called once per frame
    void Update()
    {
        // Move the pipe to the left
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Check if the pipe's x position is beyond the dead zone
        if (transform.position.x < deadZone)
        {
            // Destroy the pipe gameObject
            Destroy(gameObject);
        }
    }
}
