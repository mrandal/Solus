using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalMenuSystem : MonoBehaviour
{
    public GameObject journal;
    public GameObject[] pages;
    public bool firstPage;
    public bool secondPage;
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
        for(int i = 0; i < pages.Length; i++)
            {
                pages[i].SetActive(false);
            }
        Time.timeScale = 1;
        
    }
}
