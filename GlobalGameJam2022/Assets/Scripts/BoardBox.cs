using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardBox : MonoBehaviour
{
    [SerializeField] bool moveUp = true, moveDown = true, moveLeft = true, moveRight = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")) {
            Player p = collision.gameObject.GetComponent<Player>();
            p.moveUp = moveUp;
            p.moveDown = moveDown;
            p.moveLeft = moveLeft;
            p.moveRight = moveRight;

            if (!p.blackPlayer) {              
                GetComponent<SpriteRenderer>().sprite = p.white;
                gameObject.tag = "White";
                Manage.instance.CollectFX();
            }
            else {
                GetComponent<SpriteRenderer>().sprite = p.black;
                gameObject.tag = "Black";
                Manage.instance.CollectFX();
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Player p = collision.gameObject.GetComponent<Player>();
            p.moveUp = moveUp;
            p.moveDown = moveDown;
            p.moveLeft = moveLeft;
            p.moveRight = moveRight;

            if (!p.blackPlayer)
            {
                GetComponent<SpriteRenderer>().sprite = p.white;
                gameObject.tag = "White";
                Manage.instance.CollectFX();
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = p.black;
                gameObject.tag = "Black";
                Manage.instance.CollectFX();
            }
        }
    }
}
