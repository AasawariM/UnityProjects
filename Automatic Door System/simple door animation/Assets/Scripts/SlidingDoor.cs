using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    public Animator myAnim;
    public string PlayerTag;
    public string OpenCloseAnimBoolName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == PlayerTag) { 
        myAnim.SetBool(OpenCloseAnimBoolName, true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == PlayerTag)
        {
            myAnim.SetBool(OpenCloseAnimBoolName, false);
        }
    }
}
