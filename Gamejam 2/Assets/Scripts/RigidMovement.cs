using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float Senesitivity;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {

        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * Senesitivity, 0)));
        rb.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * speed) + (transform.right * Input.GetAxis("Horizontal") * speed));

    }
}
