using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Speedometer : MonoBehaviour
{
    public Rigidbody PlayerRB;

    [SerializeField] float speed;
    [SerializeField] TextMeshProUGUI speedometerText;

    void Start()
    {
        
    }
    void Update()
    {
        speed = Mathf.Round(PlayerRB.velocity.magnitude * 2.237f);
        speedometerText.SetText(speed + " MPH");
    }
}
