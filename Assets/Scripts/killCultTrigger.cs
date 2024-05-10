using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killCultTrigger : MonoBehaviour
{
    public Collider2D cult;
    public GameObject cultObj;
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
        if (other == cult)
        {
            cultObj.SetActive(false);
        }
    }
}
