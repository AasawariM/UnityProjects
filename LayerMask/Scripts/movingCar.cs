using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingCard : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private Transform _rayOrigin;
    private float rayDistance = 13f;

    private float _laneChangeSpeed = 30f;
    
    private float _leftLanex = 107.5f;
    private float _rightLanex = 137.3f;
    
    private bool isInLeftLane = true;
    private bool isMovingLanes = false;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);

        RaycastHit hit;

        Debug.DrawRay(_rayOrigin.position, transform.forward * rayDistance, Color.red);
        if (Physics.Raycast(_rayOrigin.position, transform.forward, out hit,rayDistance ))
        {
            //Debug.Log("Found an object named: " + hit.transform.name);
            isMovingLanes = true;     
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isMovingLanes = true;
        }

        if (isMovingLanes)
        {
            MoveLane();
        }
    }
    // move lane
    private void MoveLane()
    {
        if (isInLeftLane)
        {
            transform.Translate(Vector3.right * _laneChangeSpeed * Time.deltaTime);
            //Debug.Log("right");
            Debug.Log(transform.position.x +" > "+ _rightLanex + "="+(transform.position.x > _rightLanex));
            if (transform.position.x > _rightLanex)
            {
                isMovingLanes = false;
                isInLeftLane = false;
                
            }
        }
        else
        {
            transform.Translate(Vector3.left * _laneChangeSpeed * Time.deltaTime);
            Debug.Log("left");
            if (transform.position.x < _leftLanex)
            {
                isMovingLanes = false;
                isInLeftLane = true;

            }
        }
    }
}
