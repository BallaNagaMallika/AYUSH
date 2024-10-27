using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLookat : MonoBehaviour
{
    public Transform playerTransform;  // Reference to the player's transform
    public Vector3 offset;             // Offset from the player
    public float smoothSpeed = 0.125f; // Smooth transition speed for the camera
    public bool rotateWithPlayer = true; // Whether the camera rotates with the player

    void LateUpdate()
    {
        // Target position is the player's position + offset
        Vector3 desiredPosition = playerTransform.position + offset;

        // Smoothly transition to the target position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Set the camera's position to the smoothed position
        transform.position = smoothedPosition;

        // Rotate the camera with the player if required
        if (rotateWithPlayer)
        {
            // Adjust the rotation of the camera to match the player's rotation
            Quaternion desiredRotation = Quaternion.Euler(0, playerTransform.eulerAngles.y, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, smoothSpeed);
        }

        // Optional: Make the camera look at the player (if you want the camera to always focus on the player)
        // transform.LookAt(playerTransform);
    }
}
