﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearlvlpartonedoorx : MonoBehaviour
{
    [SerializeField] private int num;
    [SerializeField]
    private dooropenx door1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reduceenemy()
    {
        num = num - 1;
        if (num == 0)
        {
            door1.opendoor();
            
        }
    }
}
