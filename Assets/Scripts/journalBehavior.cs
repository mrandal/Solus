using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class journalBehavior : MonoBehaviour
{
    public Collider2D damien;
    public GameObject journalObj;
    public GameObject journal;
    public GameObject[] pages = {};
    public AudioSource journalSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other == damien)
        {
            journalSound.Play();
            journalObj.SetActive(false);
            Time.timeScale = 0;
            journal.SetActive(true);
            for(int i = 0; i < pages.Length; i++)
            {
                pages[i].SetActive(true);
            }
        }
        
    }
}
