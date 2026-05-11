using UnityEngine;

public class MouseClickRaycast : MonoBehaviour
{
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.blue);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit object: " + hit.collider.gameObject.name);
                if (hit.collider.gameObject.name != "Plane")
                    hit.transform.GetComponent<Renderer>().material.color = Color.grey; //change color of object on hit
                //Destroy(hit.collider.gameObject);
            }
        }
    }
}