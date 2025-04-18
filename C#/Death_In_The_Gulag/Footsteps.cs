using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    [Header("Default Footsteps")]
    [SerializeField] private AudioClip[] dirtFootstepsSFX;

    [Header("Surface Footsteps")]
    [SerializeField] private AudioClip[] woodPlankFootstepsSFX;
    [SerializeField] private AudioClip[] snowFootstepsSFX;
    [SerializeField] private AudioClip[] woodCreakFootstepsSFX;
    [SerializeField] private AudioClip[] dirtPathFootstepsSFX; // New DirtPath sounds

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Rigidbody2D rig;
    [SerializeField] private float playRate = 0.4f;

    private float lastPlayTime;
    private AudioClip[] currentFootstepsSFX;

    // Surface tracking
    private Dictionary<string, int> surfaceCounts = new Dictionary<string, int>();
    private string currentSurfaceTag = "Default";

    private void Start()
    {
        currentFootstepsSFX = dirtFootstepsSFX;
        currentSurfaceTag = "Default";
        surfaceCounts["WoodPlank"] = 0;
        surfaceCounts["Snow"] = 0;
        surfaceCounts["WoodCreak"] = 0;
        surfaceCounts["DirtPath"] = 0; // Initialize DirtPath counter
    }

    void Update()
    {
        if (rig.velocity.magnitude > 0.1f && Time.time - lastPlayTime > playRate)
        {
            PlayFootstep();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        string tag = other.tag;

        if (!surfaceCounts.ContainsKey(tag))
            surfaceCounts[tag] = 0;

        surfaceCounts[tag]++;
        UpdateFootsteps(tag);

        Debug.Log($"Entered {tag}: Count = {surfaceCounts[tag]}");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        string tag = other.tag;

        if (surfaceCounts.ContainsKey(tag) && surfaceCounts[tag] > 0)
        {
            surfaceCounts[tag]--;
        }

        // Only reset to default when exiting the *current* surface
        UpdateFootsteps(FindMostRelevantSurface());
        Debug.Log($"Exited {tag}: Count = {surfaceCounts[tag]}");
    }

    private void UpdateFootsteps(string surfaceTag)
    {
        switch (surfaceTag)
        {
            case "WoodPlank":
                currentFootstepsSFX = woodPlankFootstepsSFX;
                break;
            case "Snow":
                currentFootstepsSFX = snowFootstepsSFX;
                break;
            case "WoodCreak":
                currentFootstepsSFX = woodCreakFootstepsSFX;
                break;
            case "DirtPath":
                currentFootstepsSFX = dirtPathFootstepsSFX;
                break;
            default:
                currentFootstepsSFX = dirtFootstepsSFX;
                break;
        }
    }

    private string FindMostRelevantSurface()
    {
        if (surfaceCounts["WoodCreak"] > 0) return "WoodCreak";
        if (surfaceCounts["Snow"] > 0) return "Snow";
        if (surfaceCounts["WoodPlank"] > 0) return "WoodPlank";
        if (surfaceCounts["DirtPath"] > 0) return "DirtPath";
        return "Default";
    }

    private void PlayFootstep()
    {
        lastPlayTime = Time.time;

        if (currentFootstepsSFX != null && currentFootstepsSFX.Length > 0)
        {
            AudioClip clipToPlay = currentFootstepsSFX[Random.Range(0, currentFootstepsSFX.Length)];
            audioSource.PlayOneShot(clipToPlay);
        }
    }
}
