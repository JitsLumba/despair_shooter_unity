﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlecollisionbomberz : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private ethanbomberaiz ethanaipl;
    [SerializeField] private projectilefire projfire;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnParticleCollision(GameObject other)
    {
        if (other.name.Contains("Blow"))
        {

            ethanaipl.blowaway();
        }
    }
    
}
