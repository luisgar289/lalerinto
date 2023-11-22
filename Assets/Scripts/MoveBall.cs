using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    private float jumpInput;
    private float speed = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(horizontalInput, 0.0f , verticalInput) * speed);
        //solo hacer un salto
        if (jumpInput > 0.0f && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector3(0.0f, 6.0f, 0.0f), ForceMode.Impulse);
        }
    }
}