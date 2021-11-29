using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerAvatar : MonoBehaviour
{
    public Animator animator;

    private float nextActionTime = 0.0f;
    public float updateCheckPeriod = 0.1f;
    private Vector3 lastPosition = Vector3.zero;

    void Start()
    {
        animator.SetFloat("MoveSpeed", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            float distance = Vector3.Distance(transform.position, lastPosition);
            animator.SetFloat("MoveSpeed", distance);

            lastPosition = transform.position;
            nextActionTime += updateCheckPeriod;

            Debug.Log(animator.GetFloat("MoveSpeed"));
        }
    }
}
