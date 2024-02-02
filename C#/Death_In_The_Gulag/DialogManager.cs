using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TMP_Text dialogText;
    public GameObject dialogBox;
    public string[] dialogLines;
    public int currentLine;
    public static DialogManager instance;

    // Static variable to track if dialogue is active
    public static bool isDialogueActive;

    private bool justStarted;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogBox.activeInHierarchy)
        {
            PlayerController.instance.canMove = false;  // Disable player movement during dialogue

            if (Input.GetButtonDown("Fire1"))
            {
                if (!justStarted)
                {
                    if (currentLine < dialogLines.Length - 1)
                    {
                        currentLine++;
                        dialogText.text = dialogLines[currentLine];
                    }
                    else
                    {
                        // Hide the dialog box when there's no more dialogue
                        dialogBox.SetActive(false);
                        PlayerController.instance.canMove = true;  // Re-enable player movement after dialogue ends

                        // Set isDialogueActive to false when dialogue ends
                        isDialogueActive = false;
                    }
                }
                else
                {
                    justStarted = false;
                }
            }
        }
    }

    public void ShowDialog(string[] newLines)
    {
        dialogLines = newLines;
        currentLine = 0;
        dialogText.text = dialogLines[0];
        dialogBox.SetActive(true);
        justStarted = true;

        PlayerController.instance.canMove = false;  // Disable player movement when dialogue starts

        // Set isDialogueActive to true when dialogue starts
        isDialogueActive = true;
    }
}
