using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsManager : MonoBehaviour
{
    public GameObject Controls;
    // Start is called before the first frame update
    void Start()
    {
        Controls.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showControls()
    {
        if(!Controls.activeSelf)
        {
            Controls.SetActive(true);
        }
        else
        {
            Controls.SetActive(false);
        }
    }
}
