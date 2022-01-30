using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
public class OnConnected : MonoBehaviourPunCallbacks
{
    public InputField pName;
    void CreateAndJoinRoom() {
        string roomName = "r" + Random.Range(0, 1000);
        RoomOptions roomOpt = new RoomOptions
        {
            IsOpen = true,
            IsVisible = true,
            MaxPlayers = 2
        };
        PhotonNetwork.CreateRoom(roomName, roomOpt);
    }
    public void JoinRoom() {
        PhotonNetwork.NickName = pName.text;
        PhotonNetwork.JoinRandomRoom();
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        CreateAndJoinRoom();
        base.OnJoinRandomFailed(returnCode, message);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(1);
    }
}