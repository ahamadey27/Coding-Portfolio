using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;

    [SerializeField]
    private float _startDelay = 2.0f; // Delay before enemy starts moving
    private bool _canMove = false; // Flag to control the enemy's movement

    private Player _player; 
    private Animator _anim; 

    private AudioSource _audioSource; 

    void Start()
    
    {
        StartCoroutine(StartMoving());
        _player = GameObject.Find("Player").GetComponent<Player>(); 
        _audioSource = GetComponent<AudioSource>(); 
        if (_player == null)
        {
            Debug.LogError("Player is NULL"); 
        }

        _anim = GetComponent<Animator>();

        if (_anim == null)
        {
            Debug.LogError("The animation is NULL"); 
        }
    }

    void Update()
    {
        if (_canMove)
        {
            MoveEnemy();
        }
    }

    private IEnumerator StartMoving()
    {
        yield return new WaitForSeconds(_startDelay);
        _canMove = true;
    }

    private void MoveEnemy()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -5.5f)
        {
            float randomX = Random.Range(-8.0f, 8.0f);
            transform.position = new Vector3(randomX, 8.5f, 0);
        }
    }

   private void OnTriggerEnter2D(Collider2D other)
{
    if (other.tag == "Laser")
    {
        Destroy(other.gameObject);
        if (_player != null)
        {
            _player.AddScore(10); 
        }
        _speed = 0; 
        _audioSource.Play();
        _anim.SetTrigger("OnEnemyDeath");
         


        Destroy(this.gameObject, 2.8f);
    }

    if (other.tag == "Player")
    {
        Player player = other.transform.GetComponent<Player>();
        
        if (player != null)
        {
            player.Damage();  // This line will decrease the player's life by 1
        }

        _anim.SetTrigger("OnEnemyDeath"); 

        _speed = 0; 
        _audioSource.Play(); 
        Destroy(this.gameObject, 2.8f); // This line will destroy the enemy
        ; 


    }
}
}
