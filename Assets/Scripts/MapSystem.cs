using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSystem : MonoBehaviour
{
    public GameObject map;
    public GameObject map1;
    public GameObject map2;
    public GameObject map3;
    public GameObject map1Object;
    public GameObject map2Object;
    public GameObject map3Object;
    private bool on = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(map1Object.activeSelf == false)
        {
            map1.SetActive(true);
        }
        if(map2Object.activeSelf == false)
        {
            map2.SetActive(true);
        }
        if(map3Object.activeSelf == false)
        {
            map3.SetActive(true);
        }
        if(Input.GetKey(KeyCode.Tab))
        {
            map.SetActive(true);
        }
        else
        {
            map.SetActive(false);
        }
    }
}
