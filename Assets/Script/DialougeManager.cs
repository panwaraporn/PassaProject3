﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour
{
    public Text nameText;
    public Text DialogueText;
    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        DialogueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("จบข้อความ");
    }
}
