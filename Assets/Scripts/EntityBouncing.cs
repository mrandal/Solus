using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBouncing : MonoBehaviour
{
    public float oscillationHeight;
    public float oscillationSpeed;
    public Rigidbody2D _rb;
    private float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        // oscillate up and down
        t += Time.fixedDeltaTime;
        float magnitude = oscillationHeight * Mathf.Sin((t*oscillationSpeed) * 2 * Mathf.PI);
        Vector2 pos = _rb.position + new Vector2(0, magnitude);
        _rb.MovePosition(pos);
    }
}
