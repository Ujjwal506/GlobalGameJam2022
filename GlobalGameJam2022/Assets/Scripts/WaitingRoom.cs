using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
public class WaitingRoom : MonoBehaviour
{
    public static int playerNum;
    [SerializeField] GameObject white, black, wait;
    void Start()
    {
        playerNum = PhotonNetwork.CurrentRoom.PlayerCount - 1;
        if (playerNum == 0) {
            wait.SetActive(false);
            white.SetActive(true);
        }
        if (playerNum == 1)
        {
            wait.SetActive(false);
            black.SetActive(true);
        }
    }
    void Update() {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
            SceneManager.LoadScene(2);
    }
}
