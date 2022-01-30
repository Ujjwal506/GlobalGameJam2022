using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject[] playerCharacter;
    void Start()
    {
        Vector3 spawnPos = spawnPoints[WaitingRoom.playerNum].position;
        PhotonNetwork.Instantiate(playerCharacter[WaitingRoom.playerNum - 1].name, spawnPos, Quaternion.identity);
    }
}
