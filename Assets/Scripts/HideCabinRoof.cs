using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCabinRoof : MonoBehaviour
{
    public GameObject roof;
    public Collider2D damien;
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
            roof.SetActive(false);
        }
    }
}
