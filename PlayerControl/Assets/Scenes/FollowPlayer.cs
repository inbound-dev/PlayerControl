using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Vector3 offset = new Vector3(0, 5, -15);

    public GameObject car;

    void LateUpdate()
    {
        transform.position = car.transform.position + offset;
    }
}
