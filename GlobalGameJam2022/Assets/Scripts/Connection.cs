using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Connection : MonoBehaviourPunCallbacks
{
    public GameObject onConnecting, onConnected;
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        onConnecting.SetActive(false);
        onConnected.SetActive(true);
    }
    public void PlayPressed() {
        onConnected.SetActive(false);
        onConnecting.SetActive(true);        
    }
}
