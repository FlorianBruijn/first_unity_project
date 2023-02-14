using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch_cube : MonoBehaviour
{
    Rigidbody rb;
    public float rbThrust = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, rbThrust, 0, ForceMode.Impulse);
            Debug.Log("spatie");
        }
    }
}
