﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        lvlmanager.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMainMenuClicked()
    {
        lvlmanager.Instance.LoadGame();
    }
}
