using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoverjet : MonoBehaviour
{
    //PUT A CLOSE TO CENTER TO BASE AS POSSIBLE
    Rigidbody rbody;
    float distance;
    [SerializeField]
    float antigravForce;
    RaycastHit hit;

    void Start()
    {
        rbody = GetComponentInParent<Rigidbody>();
        distance = 1.0f;
    }
    void FixedUpdate()
    {
        antigravForce = rbody.mass;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, distance))
        {
            rbody.AddForceAtPosition(transform.up * (distance - hit.distance) / distance * antigravForce, transform.position, ForceMode.Impulse);
        }
    }
}
