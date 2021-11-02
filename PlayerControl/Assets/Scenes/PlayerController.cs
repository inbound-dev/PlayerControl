using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject car;

    [SerializeField] float speed = 20f;
    [SerializeField] float turnSpeed = 50f;

    private float horizontalInput;

    [SerializeField] Vector3 offset = new Vector3(0, 5, -7);

    void Start()
    {
        transform.position = player.transform.position = offset;
    }
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput);
    }
}
