using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class DesktopLobby : MonoBehaviourPunCallbacks
{
    public InputField CreateRoomName;
    public Button CreateRoomButton;
    public Button JoinRoomButton;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        CreateRoomButton.onClick.AddListener(CreateRoom);
        JoinRoomButton.onClick.AddListener(JoinRoom);
    }

    void CreateRoom()
    {
        if (CreateRoomName.text != "")
        {
            PhotonNetwork.CreateRoom(CreateRoomName.text);
        }
        else
        {
            Debug.Log("NAME CANNOT BE EMPTY!!!");
        }
    }

    void JoinRoom()
    {
        PhotonNetwork.JoinRoom(CreateRoomName.text);
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("We have connected to the " + PhotonNetwork.CloudRegion + " region!");
        PhotonNetwork.JoinLobby();
    }


    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        PhotonNetwork.LoadLevel("DESKTOPGAME");
    }
}
