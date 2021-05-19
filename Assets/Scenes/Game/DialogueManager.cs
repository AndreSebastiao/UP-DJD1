using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueBox;
    [SerializeField] Text dialogueText;
    [SerializeField] int letterPerSecond;

    public static DialogueManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    Dialogue dialogue;
    int currentLine = 0;

    public void ShowDialogue(Dialogue dialogue)
    {
        this.dialogue = dialogue;
        dialogueBox.SetActive(true);
        dialogueText.text = dialogue.Lines[0];
    }

    public void HandleUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ++currentLine;
            if (currentLine < dialogue.Lines.Count)
            {
                dialogueText.text = dialogue.Lines[currentLine];
            }
            else
            {
                currentLine = 0;
                dialogueBox.SetActive(false);
            }
        }
    }
}
