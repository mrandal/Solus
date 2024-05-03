using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlashlightBehavior : MonoBehaviour
{
    public Collider2D damien;
    public Collider2D flashlight;
    public UnityEngine.Rendering.Universal.Light2D playerLight;
    public GameObject flashlightObject;
    public GameObject flashlightInv;
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
            Destroy(gameObject);
            playerLight.pointLightOuterRadius = 3.5f;
            flashlightObject.GetComponent<Dialogue>().enabled = true;
            flashlightInv.SetActive(true);
            // give flashlight light
        }
        
    }
}
