﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class InstancedBehaviourScript : MonoBehaviour
{
    public Color color = Color.white;
    void Start()
    {
        var rendere = GetComponent<Renderer>();
        Assert.IsNotNull(rendere);

        MaterialPropertyBlock block = new MaterialPropertyBlock();
        block.SetColor("_Color", color);

        rendere.SetPropertyBlock(block);
    }

    void Update()
    {
        
    }
}
