using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage : MonoBehaviour
{
    [SerializeField] GameObject[] box;
    int whiteCount, blackCount;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void Count() {
        whiteCount = blackCount = 0;
        for (int i = 0; i < box.Length; i++) {
            if (box[i].tag.Equals("White"))
                whiteCount++;
            else if (box[i].tag.Equals("Black"))
                blackCount++;
        }
    }
}
