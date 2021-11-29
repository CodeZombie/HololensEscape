using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionResetter : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = gameObject.transform.position;
        originalRotation = gameObject.transform.rotation;
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10)
        {
            rigidbody.transform.localRotation = originalRotation;
            rigidbody.transform.position = originalPosition;

            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;


        }
    }
}