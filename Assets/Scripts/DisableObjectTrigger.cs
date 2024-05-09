using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public GameObject[] disabledObjects;
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
            foreach(GameObject disabledObject in disabledObjects)
            {
                disabledObject.SetActive(false);
            }
        }
    }
}
