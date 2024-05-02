using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareTrigger : MonoBehaviour
{
    private bool triggered = false;
    public GameObject jumpscare;
    public Collider2D damien;
    public float jumpscareDuration;
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
            if(!triggered)
            {
                triggered = true;
                Time.timeScale = 0;
                StartCoroutine(ShowJumpscare());

            }
        }
    }

    IEnumerator ShowJumpscare()
    {
        jumpscare.SetActive(true);
        yield return new WaitForSecondsRealtime(jumpscareDuration);
        jumpscare.SetActive(false);
        Time.timeScale = 1;
    }
}
