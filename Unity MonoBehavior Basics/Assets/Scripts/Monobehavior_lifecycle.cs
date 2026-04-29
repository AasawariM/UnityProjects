using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monobehavior_lifecycle : MonoBehaviour
{
    //awake is called before the first frame and before any start() runs on any game object in the scene
    private void Awake() {
    Debug.Log("Awake() was called");
    }
    //onEnable is called once when the MonoBehavior is enabled (including the game object is created) after Awake()
    // has been called on all game objects in a scene, and before start() is called on any gameObject.
    private void OnEnable() {
        Debug.Log("OnEnable() was called");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start() was called");
    }

    // Update is called once per frame
    void Update()
    {
        // Disabling this script stops Update() from running,
        // so it cannot re-enable itself

        //we are checking if the keyboard key alphanumeric 1 is pressed
        // it will toggle the MonoBehaviour
        //if enable then it disables it
        //if disable it wont enable it back because as monobehavior is disabled then update loop wont run 
        Debug.Log("Update running");
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            this.enabled = !this.enabled;
        }
        // If key is pressed it will distroy the whole gameObject (when you want to remove the monobehavior from the gameObject)
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destroy(gameObject);
        }
    }
    //LateUpdate 
    //FixedUpdate
    // onDisable is called once when the MonoBehavior is disabled (including when gameObject is destroyed).
    void OnDisable() {
        Debug.Log("OnDisable() was called");
    }
}
