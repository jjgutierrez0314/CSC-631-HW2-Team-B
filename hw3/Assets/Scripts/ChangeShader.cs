﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShader : MonoBehaviour
{
    public Material[] material;
    Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if (rend.sharedMaterial == material[0])
            {
                rend.sharedMaterial = material[1];
            }
            else
            {
                rend.sharedMaterial = material[0];
            }
        }
    }
}
