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
    public bool IsDialogueActive { get; private set; }

    // Static variable to track if dialogue is active
    public static bool isDialogueActive;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsDialogueActive == false)
            return;

        if (Input.GetButtonDown("Fire1"))
        {
            currentLine++;
            if (currentLine < dialogLines.Length)
            {
                dialogText.text = dialogLines[currentLine];
            }
            else
            {
                IsDialogueActive = false;
                dialogBox.SetActive(false);
                PlayerController.instance.canMove = true;
            }
        }
    }

    public void ShowDialog(string[] newLines)
    {
        IsDialogueActive = true;
        dialogBox.SetActive(true);
        PlayerController.instance.canMove = false;

        dialogLines = newLines;
        currentLine = -1;  // Start at -1 so the first line shown is at index 0

        dialogText.text = dialogLines[++currentLine];
    }
}
