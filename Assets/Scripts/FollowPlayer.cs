using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject following;
    public bool sword;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(player == null)
        {
            return;
        }
        Vector2 playerPos = player.transform.position;
        following.transform.position = new Vector2(playerPos.x, playerPos.y);
        //face mouse
        if(sword)
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            Vector2 offset = new Vector2(mousePos.x - screenPoint.x, mousePos.y - screenPoint.y);
            float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
            angle -= 180; // Adjust the angle by 0 degrees
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
