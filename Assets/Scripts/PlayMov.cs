using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMov : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardF = 2000f;
    public float sidewaysF = 500f;
    public float frontbackF = 500f;


    // Update is called once per frame
    //FixedUpdate is better while dealing with physics
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardF * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, frontbackF* Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("x"))
        {
            rb.AddForce(0, -frontbackF* Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
//Which view enables you to manipulate objects in a scene visually?
//Project View, scene view, game view or Inspector View or Hierarchy View?
//How many game objects did you create?Are assets and game objects the same?
//What happens if you double the value of rightForce? why?
//What is the class you have created in the Unity project?How many instance variables are there in the class?
//What is a rigidbody?
//How do you modify your code to allow users to press 'w' to speed up, and press 'x' to slow down the object's movement? please include this feature in your video to show your work and code.

