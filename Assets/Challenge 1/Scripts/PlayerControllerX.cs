using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 15.0f;
    public float rotationSpeed = 100.0f;
    public float verticalInput;

    void Update() // Changed to Update for smoother movement and input
    {
        // 1. Get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // 2. Move the plane forward at a constant rate
        // Added Time.deltaTime so speed is "meters per second" not "meters per frame"
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // 3. Tilt the plane up/down based on input
        // Added verticalInput so it stops rotating automatically
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}