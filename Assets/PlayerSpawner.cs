using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayerSpawner : MonoBehaviour
{
    public GameObject PlayerAvatar;
    // Start is called before the first frame update
    void Start()
    {
        PlayerAvatar.GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerAvatar.transform.localPosition = this.transform.localPosition;
        PlayerAvatar.transform.localRotation = this.transform.localRotation;
    }
}
