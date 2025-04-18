using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] MusicSource;
    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);  // Prevent duplicate AudioManagers
        }
    }

    public void PlayMusic(int musicToPlay, float fadeDuration = 1.0f)
    {
        if (musicToPlay < MusicSource.Length)
        {
            StartCoroutine(FadeIn(MusicSource[musicToPlay], fadeDuration));
        }
    }

    public void StopMusic(float fadeDuration = 1.0f)
    {
        for (int i = 0; i < MusicSource.Length; i++)
        {
            if (MusicSource[i].isPlaying)
            {
                StartCoroutine(FadeOut(MusicSource[i], fadeDuration));
            }
        }
    }

    // Coroutine to fade in music
    private IEnumerator FadeIn(AudioSource audioSource, float fadeDuration)
    {
        audioSource.volume = 0;
        audioSource.Play();

        float startVolume = 0f;
        while (audioSource.volume < 1)
        {
            audioSource.volume += Time.deltaTime / fadeDuration;
            yield return null;
        }

        audioSource.volume = 1f;
    }

    // Coroutine to fade out music
    private IEnumerator FadeOut(AudioSource audioSource, float fadeDuration)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / fadeDuration;
            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;  // Reset volume for the next time it plays
    }

    public void PlaySFX(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);  // Plays the sound at the camera's location
    }
}
