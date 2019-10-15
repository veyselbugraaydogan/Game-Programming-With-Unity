using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 6;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    private float hRotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = speed * 5;
        hRotationSpeed = speed * 2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up * hRotationSpeed * Time.deltaTime * horizontalInput);
    }
}
