using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    bool IsGravityEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void EnableGravity()
    {
        IsGravityEnabled = true;
    }

    public void DisableGravity()
    {
        IsGravityEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGravityEnabled)
        {
            //fall back down to the earth.

        }
    }
}
