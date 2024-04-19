using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlashlightBehavior : MonoBehaviour
{
    public Collider2D flashlight;
    public UnityEngine.Rendering.Universal.Light2D playerLight;
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
        Destroy(gameObject);
        playerLight.pointLightOuterRadius = 3.5f;
        // give flashlight light
    }
}
