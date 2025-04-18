using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Set the correct music index for the menu music
    public int menuMusicIndex = 0;

    // Audio clip for button click sound
    public AudioClip buttonClickSound;

    void Start()
    {
        // Ensure the correct music is played when the main menu scene starts
        AudioManager.instance.StopMusic(1.0f);  // Fade out any previous music
        AudioManager.instance.PlayMusic(menuMusicIndex, 1.0f);  // Play menu music at index 4
    }

    public void PlayGame()
    {
        // Play button click sound
        AudioManager.instance.PlaySFX(buttonClickSound);

        // Fade out menu music before starting game
        AudioManager.instance.StopMusic(1.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  // Load the next scene
    }

    public void QuitGame()
    {
        // Play button click sound
        AudioManager.instance.PlaySFX(buttonClickSound);

        Debug.Log("Player Has Quit");
        Application.Quit();
    }
}
