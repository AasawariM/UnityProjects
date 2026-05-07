using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastEmitter : MonoBehaviour
{

    public float distance = 10f;
    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position,transform.forward);
        RaycastHit hit;
        bool hitObject = Physics.Raycast(ray,out hit,distance);
        if(hitObject)
        {
            Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);
            Debug.Log("Did Hit"+hit.collider.name);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.forward * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
}
