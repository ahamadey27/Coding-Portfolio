﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{

    [SerializeField]
    private float _speed = 5.0f;

    [SerializeField] // 0 = triple shot 1 = speed 2 = shield 
    private int powerupID; 

    [SerializeField]
    private AudioClip _clip; 

    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime); 

        if (transform.position.y < -4.5f)
        {
            Destroy(this.gameObject); 
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>(); 

            AudioSource.PlayClipAtPoint(_clip, transform.position); 
            
            if (player != null)
            {
                switch(powerupID)
                {
                    case 0: 
                        player.TripleShotActive();
                        break; 
                    case 1:  
                        player.SpeedBoostActive(); 
                        break; 
                    case 2: 
                        player.ShieldsActive(); 
                        break; 
                }
            }
            Destroy(this.gameObject); 
        }
    }
}
