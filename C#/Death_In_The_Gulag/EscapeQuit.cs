using UnityEngine;

public class EscapeQuit : MonoBehaviour
{
    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Exiting game...");
            Application.Quit();
        }
    }
}