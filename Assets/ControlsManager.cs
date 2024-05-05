using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsManager : MonoBehaviour
{
    public GameObject Controls;
    private bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showControls()
    {
        if(!on)
        {
            Controls.SetActive(true);
            on = true;
        }
        else
        {
            Controls.SetActive(false);
            on = false;
        }
    }
}
