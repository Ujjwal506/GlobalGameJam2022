using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackAccesTower : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")) {
            if (collision.gameObject.GetComponent<Player>().changeForm)
                GetComponent<BoxCollider2D>().isTrigger = true;
            else
                GetComponent<BoxCollider2D>().isTrigger = false;
        }            
    }
}
