using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Player : MonoBehaviour
{
    [HideInInspector] public bool moveUp, moveDown, moveLeft, moveRight;
    public Sprite white, black;
    Vector3 lastPos;
    PhotonView view;
    private void Start()
    {
        WaitingRoom.playerNum = PhotonNetwork.CurrentRoom.PlayerCount - 1;
        view = GetComponent<PhotonView>();
    }
    void Update()
    {
        if (view.IsMine && PhotonNetwork.CurrentRoom.PlayerCount == 2) {
            if (Input.GetKeyDown(KeyCode.W))
            {
                lastPos = transform.position;
                if (moveUp)
                    transform.position = new Vector3(transform.position.x, transform.position.y + 12, transform.position.z);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                lastPos = transform.position;
                if (moveDown)
                    transform.position = new Vector3(transform.position.x, transform.position.y - 12, transform.position.z);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                lastPos = transform.position;
                if (moveLeft)
                    transform.position = new Vector3(transform.position.x - 12, transform.position.y, transform.position.z);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                lastPos = transform.position;
                if (moveRight)
                    transform.position = new Vector3(transform.position.x + 12, transform.position.y, transform.position.z);
            }
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals(gameObject.tag))
        {
            transform.position = lastPos;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("White") || collision.gameObject.tag.Equals("Black")) {
            transform.position = collision.transform.position;
        }
    }
}
