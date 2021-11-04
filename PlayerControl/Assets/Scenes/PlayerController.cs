using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public GameObject car;
    public GameObject centerOfMass;

    private Rigidbody PlayerRB;

    [SerializeField] float horsePower;
    [SerializeField] float turnSpeed = 50f;

    private float horizontalInput;
    private float forwardInput; 

    void Start(){
        PlayerRB = GetComponent<Rigidbody>();
        centerOfMass.transform.position = centerOfMass.transform.position;
    }

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        PlayerRB.AddRelativeForce(Vector3.forward *  forwardInput * horsePower);
        car.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
