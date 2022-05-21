﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private bool isAlive;
    [SerializeField] private int numNeighbours;
    private SpriteRenderer spriteRendR;

    // Start is called before the first frame update
    void Start()
    {
        isAlive = false;
        numNeighbours = 0;
        spriteRendR = GetComponent<SpriteRenderer>();
    }

    private void SetAlive(bool alive){
        isAlive = alive;

        if(alive){
            spriteRendR.enabled = true;
        }else{
            spriteRendR.enabled = false;
        }
    }
}