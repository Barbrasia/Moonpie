using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterController : MonoBehaviour
{

    public float GravityScale = 1;
    public float Speed = 1;
    public Rigidbody rb;
    public LayerMask mask;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * Speed, ForceMode.Force);
        }
    }

    private void FixedUpdate()
    {
        bool raycast = Physics.Raycast(transform.position, -transform.up, out RaycastHit hitInfo, Mathf.Infinity, mask);
        if (raycast)
        {
            rb.AddForce(-hitInfo.normal.normalized * GravityScale, ForceMode.Force);
            transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
    }
}
