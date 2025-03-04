using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private float speed = 20.0f;
    private float rotationspeed = 80.0f;
    private float horizontalInput;
    private float forwardInput;
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Vertical");       

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up * rotationspeed * horizontalInput * Time.deltaTime);
    }
}
