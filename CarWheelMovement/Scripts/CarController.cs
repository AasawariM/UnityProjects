using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelCollider[] wheel_col;
    public Transform[] wheels;
    float torque = 200;
    float angle = 45;

    void FixedUpdate()
    {
        for (int i = 0; i < wheel_col.Length; i++)
        {
            // Forward and backward movement
            wheel_col[i].motorTorque = Input.GetAxis("Vertical") * torque;

            // Steering for front wheels
            if (i == 0 || i == 2) // We will set the steering angle and motor torque only to the front wheels. i.e at index 0 and 2 (front wheels)
            {
                wheel_col[i].steerAngle = Input.GetAxis("Horizontal") * angle;
            }
            // Update wheel mesh position and rotation
            var pos = transform.position;
            var rot = transform.rotation;
            wheel_col[i].GetWorldPose(out pos, out rot);
            wheels[i].position = pos;
            wheels[i].rotation = rot;

        }
        // Brake system

        if (Input.GetKey(KeyCode.Space))
            {
                foreach (var i in wheel_col)
                {
                i.motorTorque = 0;
                i.brakeTorque = 2000;
                }
            }
            else
            {   //reset the brake torque when another key is pressed
                foreach (var i in wheel_col)
                {
                    i.brakeTorque = 0;
                }

            }
        



    }
}