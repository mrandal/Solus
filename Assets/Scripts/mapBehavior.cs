using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapBehavior : MonoBehaviour
{
    public Collider2D map;
    public GameObject gameObject;
    public GameObject mapObject;
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
        gameObject.SetActive(false);
        //add section to map
    }
}
