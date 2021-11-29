using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NetworkController : MonoBehaviourPunCallbacks
{

    public InputField CreateRoomName;
    public Button CreateRoomButton;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();

        CreateRoomButton.onClick.AddListener(CreateRoom);
    }

    void CreateRoom()
    {
        if(CreateRoomName.text != "")
        {
            PhotonNetwork.CreateRoom(CreateRoomName.text);
        }
        else
        {
            Debug.Log("NAME CANNOT BE EMPTY!!!");
        }
        
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("We have connected to the " + PhotonNetwork.CloudRegion + " region!");
        PhotonNetwork.JoinLobby();
    }

    public void JoinRoom(string name)
    {
        PhotonNetwork.JoinRoom(name);
    }


    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        SceneManager.LoadScene("Lobby");
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        PhotonNetwork.LoadLevel("Game");
    }
}
