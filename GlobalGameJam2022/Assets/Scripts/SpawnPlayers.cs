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
        if (WaitingRoom.playerNum == 1)
            PhotonNetwork.Instantiate(playerCharacter[WaitingRoom.playerNum].name, spawnPoints[WaitingRoom.playerNum].position, Quaternion.identity)
                .GetComponent<Player>().blackPlayer = true;
        else
            PhotonNetwork.Instantiate(playerCharacter[WaitingRoom.playerNum].name, spawnPoints[WaitingRoom.playerNum].position, Quaternion.identity);
    }
}
