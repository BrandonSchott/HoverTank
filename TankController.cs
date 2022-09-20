using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TankController : MonoBehaviour
{
    Rigidbody rbody;
    [SerializeField]
    float rotationSpeed = 100.0f;
    [SerializeField]
    float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.W))
        {
            rbody.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rbody.AddRelativeForce(Vector3.forward * -speed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
