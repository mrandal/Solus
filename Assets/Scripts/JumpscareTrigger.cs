using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareTrigger : MonoBehaviour
{
    private bool triggered = false;
    public GameObject jumpscare;
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
        if(!triggered)
        {
            triggered = true;
            Time.timeScale = 0;
            StartCoroutine(ShowJumpscare());

        }
    }

    IEnumerator ShowJumpscare()
    {
        jumpscare.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        jumpscare.SetActive(false);
        Time.timeScale = 1;
    }
}
