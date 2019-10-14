using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{



    private float speed = 30;
    private float horizontalInput;
    private float verticalInput;
    private float turnspeed;

    // Start is called before the first frame update
    void Start()
    {
        turnspeed = speed;
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");

        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput * verticalInput);


    }
}
