using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tachometer : MonoBehaviour
{
    public Rigidbody PlayerRB;

    [SerializeField] float rpm;
    [SerializeField] float speed;
    [SerializeField] TextMeshProUGUI tachText;

    void Start()
    {

    }
    void Update()
    {
        speed = Mathf.Round(PlayerRB.velocity.magnitude * 2.237f);
        rpm  = Mathf.Round((speed % 30)*40);

        tachText.SetText(rpm + " RPM");
    }
}
