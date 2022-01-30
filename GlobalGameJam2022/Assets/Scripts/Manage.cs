using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manage : MonoBehaviour
{
    [SerializeField] GameObject[] box;
    [HideInInspector]public int whiteCount = 0, blackCount = 0;
    [SerializeField] Text black, white;
    public AudioClip onMove, onCollect;
    AudioSource movefx, collectfx;
    public static Manage instance;
    public GameObject winBlack, winWhite;
    private void Start()
    {
        movefx = gameObject.AddComponent<AudioSource>();
        movefx.clip = onMove;
        movefx.playOnAwake = false;
        collectfx = gameObject.AddComponent<AudioSource>();
        collectfx.clip = onCollect;
        collectfx.playOnAwake = false;
    }
    public void Count() {
        whiteCount = blackCount = 0;
        for (int i = 0; i < box.Length; i++) {
            if (box[i].tag.Equals("White"))
                whiteCount++;
            else if (box[i].tag.Equals("Black"))
                blackCount++;
        }
        white.text = "Score : " + whiteCount.ToString();
        black.text = "Score : " + blackCount.ToString();
    }
    public void MoveFX() {
        movefx.Play();
    }
    public void CollectFX()
    {
        collectfx.Play();
    }
}
