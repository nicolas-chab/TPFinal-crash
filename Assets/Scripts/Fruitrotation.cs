﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruitrotation : MonoBehaviour
{

    public float rotation;

    void Start()
    {
  
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotation, 0);
       
        

    }
}
