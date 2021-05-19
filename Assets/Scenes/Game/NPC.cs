using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] Dialogue dialogue;

    public void Interact()
    {
        DialogueManager.Instance.ShowDialogue(dialogue);
    }
}
