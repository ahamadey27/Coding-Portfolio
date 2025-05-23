﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

   [SerializeField]
    private float _speed = 8.0f;  

    void Update()
    {
      CalculateMovement(); 
    }
    void CalculateMovement()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime); 

        if (transform.position.y > 8f) 
        {
            Destroy(this.gameObject); 
        }
    }
}
