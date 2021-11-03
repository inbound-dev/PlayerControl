using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject car;

    [SerializeField] float speed = 20f;
    [SerializeField] float turnSpeed = 50f;

    private float horizontalInput;
    private float forwardInput;

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        car.transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        car.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
