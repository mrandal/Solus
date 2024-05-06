using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseSystem : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject controls;
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
        controls.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void PlayGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
