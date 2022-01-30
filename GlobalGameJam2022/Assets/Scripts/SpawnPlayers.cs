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
        PhotonNetwork.Instantiate(playerCharacter[WaitingRoom.playerNum].name, spawnPoints[WaitingRoom.playerNum].position, Quaternion.identity);
    }
}
