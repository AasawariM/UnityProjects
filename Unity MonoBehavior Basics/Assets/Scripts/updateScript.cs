using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Move object to right one unit per second 
        transform.Translate(Vector3.right * Time.deltaTime);
        // * Time.deltaTime bcz we dont know how many times we're getting into the update loop

        //Input should always be polled in update(), never in FixedUpdate() where it can be missed.

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //if we click space it will reset the position of the transform back to 0.
            transform.position = Vector3.zero;
        }
    }
}
