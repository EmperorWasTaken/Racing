using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCar : MonoBehaviour
{

    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, Input.GetAxis("Horizontal") * 30f * Time.deltaTime, 0f);
        _rb.AddRelativeForce(0f, 0f, -Input.GetAxis("Vertical") * 1000f * Time.deltaTime);
    }
}
