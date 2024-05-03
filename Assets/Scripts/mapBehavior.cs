using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapBehavior : MonoBehaviour
{
    public GameObject gameObject;
    public Collider2D damien;
    public bool sword;
    public GameObject swordInv;
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
            gameObject.SetActive(false);
        }
        if(sword)
        {
            swordInv.SetActive(true);
        }
        //add section to map
    }
}
