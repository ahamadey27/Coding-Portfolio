using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText; 

    [SerializeField]
    private Image _LivesImg; 
    
    [SerializeField]
    private Sprite[] _livesSprites; 

    [SerializeField]
    private Text _gameOverText; 

    [SerializeField]
    private Text _restartText; 

    private GameManager _gameManager; 

    void Start()
    {
        _scoreText.text = "Score: " + 0;  
        _gameOverText.gameObject.SetActive(false); 
        _gameManager = GameObject.Find("Game_Manager").GetComponent<GameManager>(); 

        if (_gameManager == null)
        {
            Debug.LogError("GameManager is NULL"); 
        }
    }
   public void UpdateScore(int playerScore)
    {
        if (_scoreText != null)
        {
            _scoreText.text = "Score: " + playerScore.ToString(); 
        }
        else
        {
            Debug.LogError("Score Text is NULL");
        }
    }

    public void UpdateLives(int currentLives)
    {
        _LivesImg.sprite = _livesSprites[currentLives]; 

        if(currentLives == 0)
        {
            GameOverSequence(); 
        }
    }

    void GameOverSequence()
    {
        _gameManager.GameOver(); 
        _gameOverText.gameObject.SetActive(true); 
        _restartText.gameObject.SetActive(true); 
        StartCoroutine(GameFlickerRoutine()); 
    }

    IEnumerator GameFlickerRoutine()
    {
        while(true)
        {
            _gameOverText.text = "GAME OVER"; 
            yield return new WaitForSeconds(0.4f); 
            _gameOverText.text = ""; 
            yield return new WaitForSeconds(0.4f); 
        }
    }
}
