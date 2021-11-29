using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ARPlayerNetworkHelper : MonoBehaviour
{
    public GameObject GamePieceContainer;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
