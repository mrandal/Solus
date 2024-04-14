using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    private float walkSpeed = 3f; //.003f
    private float sprintSpeed = 6f; //.005f;
    private float speed = 0f;
    private bool aDown = false;
    private bool dDown = false;
    private bool wDown = false;
    private bool sDown = false;
    private bool shiftDown = false;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1)
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
                body.AddForce(new Vector2(0, speed), ForceMode2D.Force);
            }
            if(aDown)
            {
                body.AddForce(new Vector2(-1*speed, 0), ForceMode2D.Force);
            }
            if(sDown)
            {
                body.AddForce(new Vector2(0, -1*speed), ForceMode2D.Force);
            }
            if(dDown)
            {
                body.AddForce(new Vector2(speed, 0), ForceMode2D.Force);
            }
        }
        
    }
}
