using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ARPlayerNetworkHelper : MonoBehaviour
{
    public GameObject GamePieceContainer;
    public GameObject GodHead;
    public Camera ARCamera;
    void Start()
    {
        //Go through all the objects we want to control, and request ownership of all of them.
        //The Desktop client will be instructed to validate all of these requests
        //We can then move objects around :)

        //First, we grab all the Photon View objects from the GamePieceContainer.
        foreach(PhotonView pv in GamePieceContainer.GetComponentsInChildren<PhotonView>())
        {
            pv.RequestOwnership();
        }
        GodHead.GetComponent<PhotonView>().RequestOwnership();
    }

    // Update is called once per frame
    void Update()
    {
        GodHead.transform.position = ARCamera.transform.position;
        GodHead.transform.localRotation = ARCamera.transform.localRotation;
    }
}
