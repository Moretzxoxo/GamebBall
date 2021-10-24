using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody componentRigidbody;

    public int Velocity = 4;
    public int TurnSpeed = 2;

    private void Start()
    {
        componentRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 velocity = componentRigidbody.velocity;
        velocity.x = -Velocity;
        componentRigidbody.velocity = velocity;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            componentRigidbody.AddForce(Vector3.back * TurnSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            componentRigidbody.AddForce(Vector3.forward * TurnSpeed);
        }
    }
}
