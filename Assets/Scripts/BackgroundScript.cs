using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    float walkSpeed = .003f;
    float sprintSpeed = .005f;
    float speed = 0f;
    bool aDown = false;
    bool dDown = false;
    bool wDown = false;
    bool sDown = false;
    bool shiftDown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xpos = this.gameObject.GetComponent<Rigidbody2D>().position.x;
        float ypos = this.gameObject.GetComponent<Rigidbody2D>().position.y;
        Vector3 backgroundPos = new Vector3(0.5f, 0.5f, 15.5f);

        if(Input.GetKeyDown("a"))
        {
            aDown = true;
        }
        if(Input.GetKeyDown("d"))
        { 
            dDown = true;
        }
        if(Input.GetKeyDown("w"))
        {
            wDown = true;
        }
        if(Input.GetKeyDown("s"))
        { 
            sDown = true;
        }
        if(Input.GetKeyDown("left shift"))
        { 
            shiftDown = true;
        }
        if(Input.GetKeyUp("a"))
        {
            aDown = false;
        }
        if(Input.GetKeyUp("d"))
        { 
            dDown = false;
        }
        if(Input.GetKeyUp("w"))
        {
            wDown = false;
        }
        if(Input.GetKeyUp("s"))
        { 
            sDown = false;
        }
        if(Input.GetKeyUp("left shift"))
        { 
            shiftDown = false;
        }
        if(shiftDown)
        {
            speed = sprintSpeed;
        }
        else
        {
            speed = walkSpeed;
        }
        if(wDown)
        {
            ypos -= speed;
        }
        if(aDown)
        {
            xpos += speed;
        }
        if(sDown)
        {
            ypos += speed;
        }
        if(dDown)
        {
            xpos -= speed;   
        }
        backgroundPos.x = xpos;
        backgroundPos.y = ypos;
        this.transform.position = backgroundPos;
    }
}
