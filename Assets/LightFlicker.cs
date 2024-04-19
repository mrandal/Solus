using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D light;
    public float oscillationSpeed;
    public float oscillationWidth;
    private float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        // oscillate up and down
        t += Time.fixedDeltaTime;
        float magnitude = oscillationWidth * Mathf.Sin((t*oscillationSpeed) * 2 * Mathf.PI);
        light.pointLightOuterRadius += magnitude;
    }
}
