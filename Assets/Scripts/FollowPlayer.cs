using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -10);

    void Start()
    {
        // Calculate and store the offset value by subtracting the player's position from the camera's position
        transform.position = player.transform.position + offset;
    
    }

    void LateUpdate()
    {
        // Set the position of the camera's transform to be the player's position plus the offset
        transform.position = player.transform.position + offset;
    }
}
