using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableTiles : MonoBehaviour
{
    [SerializeField] float time = 2;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
            Destroy(gameObject, time);
    }
}
