using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildRendererDisabler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer[] childRenderers = GetComponentsInChildren<MeshRenderer>();
        foreach(MeshRenderer meshRenderer in childRenderers)
        {
            meshRenderer.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
