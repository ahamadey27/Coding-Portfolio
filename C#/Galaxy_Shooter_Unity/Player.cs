using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f; 

    private float _speedMultiplier = 2; 

    [SerializeField]
    private GameObject _laserPrefab; 

    [SerializeField]
    private GameObject _tripleShotPrefab; 

    [SerializeField]
    private float _fireRate = 0.5f; 
    
    private float _canFire = -.01f; 

    [SerializeField]
    private int _lives = 3; 
   
    private SpawnManager _spawnManager; 

    [SerializeField]
    private int _score; 

    [SerializeField]
    private AudioClip _laserSoundClip; 
    private AudioSource _audioSource; 



    //POWER UPS
    private bool _isTripleShotActive = false; 
    private bool _isSpeedBoostActive = false; 
    private bool _isShieldsActive = false; 

    [SerializeField]
    private GameObject _shieldVisualizer; 

    private UIManager _uiManager; 

    void Start()
    {
        transform.position = new Vector3(0, 0, 0); 
       
        _spawnManager = GameObject.Find("Spawn_Manager").GetComponent<SpawnManager>(); 
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>(); 
        _audioSource = GetComponent<AudioSource>(); 
      
        if (_spawnManager == null)
        {
            Debug.LogError("SM is null."); 
        }

        if (_uiManager == null)
        {
            Debug.LogError("NULL"); 
        }
        if (_audioSource == null)
        {
            Debug.LogError("AudioSource is NULL"); 
        }
        else
        {
            _audioSource.clip = _laserSoundClip; 
        }
    }

    void Update()
    {
       CalculateMovement(); 

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _canFire)
        {
            FireLaser(); 
        }
    }

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        Vector3 direction = new Vector3 (horizontalInput, verticalInput, 0); 

        if (_isSpeedBoostActive == false)
        {
            transform.Translate(direction * _speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(direction * (_speed * _speedMultiplier) * Time.deltaTime);
        }


        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0); 
        }
        else if (transform.position.y <= -3.8f) 
        {
            transform.position = new Vector3(transform.position.x, -3.8f, 0); 
        }


        if (transform.position.x > 11.3f)
        {
            transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }
        else if (transform.position.x < -11.3f)
        {
            transform.position = new Vector3(11.3f, transform.position.y, 0); 
        } 
    }

    void FireLaser()
{
    _canFire = Time.time + _fireRate; 

    if (_isTripleShotActive == true)
    {
        Instantiate(_laserPrefab, transform.position + new Vector3(0, 1.05f, 0), Quaternion.identity);
        Instantiate(_laserPrefab, transform.position + new Vector3(-0.6f, 0.5f, 0), Quaternion.identity);
        Instantiate(_laserPrefab, transform.position + new Vector3(0.6f, 0.5f, 0), Quaternion.identity);
    }
    else
    {
        Instantiate(_laserPrefab, transform.position + new Vector3(0, 1.05f, 0), Quaternion.identity);
    }

    _audioSource.Play(); 
    


}
    
    public void Damage()
    {

        if (_isShieldsActive == true)
        {
            _isShieldsActive = false; 
            _shieldVisualizer.SetActive(false); 
            return; 
        }
        _lives -= 1; 

        _uiManager.UpdateLives(_lives); 

        if (_lives < 1)
        {
            _spawnManager.OnPlayerDeath(); 
            Destroy(this.gameObject); 
        }
    }


    public void TripleShotActive()
    {
        _isTripleShotActive = true; 
        StartCoroutine(TripleShotPowerDownRoutine()); 
    }

    private IEnumerator TripleShotPowerDownRoutine()
    {
        yield return new WaitForSeconds(5.0f); 
        _isTripleShotActive = false; 
    }

    public void SpeedBoostActive()
    {
        _isSpeedBoostActive = true; 
        StartCoroutine(SpeedBoostPowerDownRoutine()); 
    }

    IEnumerator SpeedBoostPowerDownRoutine()
    {
        yield return new WaitForSeconds (5.0f); 
        _isSpeedBoostActive = false; 
    }

    public void ShieldsActive()
    {
        _isShieldsActive = true; 
        _shieldVisualizer.SetActive(true); 

    }

     public void AddScore(int points)
    {
        _score += points; 
        if (_uiManager != null)
        {
            _uiManager.UpdateScore(_score);
        }
        else
        {
            Debug.LogError("UI Manager is NULL");
        }
    }





}
