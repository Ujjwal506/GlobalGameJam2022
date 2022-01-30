using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class WaitingRoom : MonoBehaviour
{
    public static int playerNum;
    void Start()
    {
        playerNum = PhotonNetwork.CurrentRoom.PlayerCount - 1;
    }
    void Update() {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
            PhotonNetwork.LoadLevel(2);
    }
}
