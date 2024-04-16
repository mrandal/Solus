using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseSystem : MonoBehaviour
{
    bool paused = false;
    public Button pauseButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PauseGame()
    {
        Debug.Log("PAUse button0");
        if(paused)
        {
            paused = false;
            Time.timeScale = 1;
        }
        else
        {
            paused = true;
            Time.timeScale = 0;
        }
    }
}
