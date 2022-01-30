using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject playerCharacter;
    void Start()
    {
        Vector3 spawnPos = spawnPoints[Random.Range(0, 1)].position;
        PhotonNetwork.Instantiate(playerCharacter.name, spawnPos, Quaternion.identity);
    }
}
