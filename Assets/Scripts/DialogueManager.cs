using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text dialogueText;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        StartCoroutine(DisplayNextSentence());
    }

    IEnumerator DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
        }
        else
        {
            int readtime = 0;
            int words = 0;
            string sentence = sentences.Dequeue();
            foreach (char letter in sentence.ToCharArray())
            {
                if (letter == ' ')
                {
                    words++;
                }
            }
            readtime = (words / 3) + 1;
            dialogueText.text = sentence;
            yield return new WaitForSeconds(readtime);
            StartCoroutine(DisplayNextSentence());
        }
    }

    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
    }

}
