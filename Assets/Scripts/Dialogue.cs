using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public GameObject dialogueBox;
    public string[] lines;
    public GameObject[] dialogueObjects;
    public float textSpeed;
    //private bool ran = false;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < dialogueObjects.Length; i++)
        {
            dialogueObjects[i].GetComponent<Dialogue>().KillDialogue();
            dialogueObjects[i].GetComponent<Dialogue>().enabled = false;
        }
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        dialogueBox.SetActive(true);
        index = 0;
        StartCoroutine(TypeLine());
    }

    public void KillDialogue()
    {
        StopAllCoroutines();
        this.lines = null;
        
    }

    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text+= c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine()
    {
        if(index < lines.Length - 1 && lines != null)
        {
            index ++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            dialogueBox.SetActive(false);
        }
    }
}
