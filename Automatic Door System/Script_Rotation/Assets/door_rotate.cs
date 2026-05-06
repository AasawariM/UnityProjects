using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoorScript
{
    [RequireComponent(typeof(AudioSource))]
    public class door_rotate : MonoBehaviour
    {
        public bool open;
        public float smooth = 1.0f;
        public GameObject door;

        float DoorOpenAngle = -90.0f;
        float DoorCloseAngle = 0.0f;

        public AudioSource asource;
        public AudioClip openDoor, closeDoor;

        void Start()
        {
            asource = GetComponent<AudioSource>();
        }

        void Update()
        {
            if (open)
            {
                var target = Quaternion.Euler(0, DoorOpenAngle, 0);
                door.transform.localRotation = Quaternion.Slerp(
                    door.transform.localRotation,
                    target,
                    Time.deltaTime * 20 * smooth
                );
            }
            else
            {
                var target1 = Quaternion.Euler(0, DoorCloseAngle, 0);
                door.transform.localRotation = Quaternion.Slerp(
                    door.transform.localRotation,
                    target1,
                    Time.deltaTime * 20 * smooth
                );
            }
        }

        public void OpenDoor()
        {
            open = !open;
            asource.clip = open ? openDoor : closeDoor;
            asource.Play();
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!open) OpenDoor();
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (open) OpenDoor();
            }
        }
    }
}