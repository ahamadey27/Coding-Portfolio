using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogActivator : MonoBehaviour
{
    [Header("Dialogue Settings")]
    public string[] lines;                    // Dialogue lines
    public AudioClip[] lineSounds;            // Audio clips corresponding to each line
    private bool canActivate;

    [Header("Audio Source")]
    public AudioSource audioSource;           // AudioSource component for playing audio clips
    [SerializeField] private float fadeDuration = 0.1f; // Duration of the crossfade (in seconds)

    void Update()
    {
        if (!canActivate) return;

        // Check for input and if dialogue is not already active
        if (Input.GetButtonDown("Fire1") && !DialogManager.instance.IsDialogueActive)
        {
            DialogManager.instance.ShowDialog(lines); // Start dialogue
            StartCoroutine(PlayLineSounds());         // Start playing sounds
            canActivate = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canActivate = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canActivate = false;
        }
    }

    private IEnumerator PlayLineSounds()
    {
        for (int i = 0; i < lines.Length; i++)
        {
            if (i < lineSounds.Length && lineSounds[i] != null)
            {
                // Fade out any currently playing audio
                yield return StartCoroutine(FadeOutAudio());

                // Play the current line sound
                audioSource.clip = lineSounds[i];
                audioSource.Play();
            }

            // Wait for the player to advance to the next line
            yield return new WaitUntil(() => !DialogManager.instance.IsDialogueActive || i != DialogManager.instance.currentLine);
        }

        // Fade out audio when dialogue ends
        StartCoroutine(FadeOutAudio());
    }

    private IEnumerator FadeOutAudio()
    {
        if (audioSource.isPlaying)
        {
            float startVolume = audioSource.volume;

            while (audioSource.volume > 0)
            {
                audioSource.volume -= startVolume * Time.deltaTime / fadeDuration;
                yield return null;
            }

            audioSource.Stop();
            audioSource.volume = startVolume; // Reset volume for the next clip
        }
    }
}
