using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Microsoft.MixedReality.Toolkit.UI;

public class ARLobby : MonoBehaviourPunCallbacks
{
    public GameObject RoomButtonTemplate;
    public GameObject RoomButtonContainer;
    private int lobbyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("We have connected to the " + PhotonNetwork.CloudRegion + " region!");
        PhotonNetwork.JoinLobby();
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        //fill the RoomButtonContainer up with the new RoomInfo objects.
        //new buttons are positioned 0.35 units in the y axis from the one above it.
        foreach(RoomInfo room in roomList)
        {
            AddRoomButton(room.Name);
        }
    }

    public void AddRoomButton(string name)
    {
        GameObject roomButton = GameObject.Instantiate(RoomButtonTemplate);
        roomButton.SetActive(true);
        roomButton.transform.parent = RoomButtonContainer.transform;
        roomButton.GetComponent<ButtonConfigHelper>().MainLabelText = name;
        roomButton.GetComponent<ButtonConfigHelper>().OnClick.AddListener(() => JoinRoom(name));
        roomButton.transform.localPosition = new Vector3(0f, 0.3f - (lobbyCount * 0.3f), -1.0f);
        roomButton.transform.localScale = new Vector3(10, 10, 1);
        roomButton.transform.localRotation = Quaternion.Euler(0, 0, 0);
        lobbyCount++;
    }

    public void JoinRoom(string name)
    {
        PhotonNetwork.JoinRoom(name);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        PhotonNetwork.LoadLevel("ARGAME");
    }

}
