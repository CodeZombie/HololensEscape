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
        originalPosition = gameObject.transform.localPosition;
        originalRotation = gameObject.transform.localRotation;
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(transform.localPosition.y < -10)
        if(Vector3.Distance(transform.localPosition, originalPosition) > 100)
        {
            rigidbody.transform.localRotation = originalRotation;
            rigidbody.transform.localPosition = originalPosition;

            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;


        }
    }
}
