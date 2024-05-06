using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalMenuSystem : MonoBehaviour
{
    public GameObject journal;
    public GameObject[] pages;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void closeJournal()
    {
        journal.SetActive(false);
        pages[0].SetActive(false);
        if(pages[1] != null)
        {
            pages[1].SetActive(false);
        }
        Time.timeScale = 1;
        
    }
}
