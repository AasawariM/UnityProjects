//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class UpdateScript : MonoBehaviour
//{

//        //In that Unity Hierarchy, every item listed under SampleScene is a GameObject.


//    // Update is called once per frame
//    //If your game runs at 60 FPS, this method runs ~60 times per second.
//    void Update()
//    {

//        // Move object to right one unit per second 
//        transform.Translate(Vector3.right * Time.deltaTime);

//        //Input should always be polled in update(), never in FixedUpdate() where it can be missed.

//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            //if we click space it will reset the position of the transform back to 0.
//            transform.position = Vector3.zero;
//        }
//    }
//}

//Explaination
//This is a simple Unity C# script that moves an object continuously and resets its position when you press the spacebar. Let’s break it down clearly.

// transform.Translate(Vector3.right * Time.deltaTime);

//What this does:
//transform = the position / rotation / scale of the GameObject.
//The Transform values for any child GameObject are displayed relative to the parent GameObject’s Transform values.These values are called local coordinates.
//Translate(...) = moves the object.(position)
//Vector3.right = direction(1, 0, 0) ? to the right.
//Time.deltaTime = time passed since last frame.
// * Time.deltaTime bcz we dont know how many times we're getting into the update loop
//Why multiply by Time.deltaTime?
//Without it, movement would depend on frame rate:
//Fast PC ? object moves faster
//Slow PC ? object moves slower
//Multiplying by Time.deltaTime makes movement smooth and consistent per second, not per frame.
//So this line means:
//“Move the object right at 1 unit per second.”

//Input.GetKeyDown is a function used to detect the exact frame a user begins pressing a specific key. It is part of the Legacy Input Manager.
//if (Input.GetKeyDown(KeyCode.Space))
//Checks if the spacebar was pressed THIS frame.
//Vector3.zero = (0, 0, 0)
//This instantly moves the object back to the world origin.

//A Vector3 is a data type that represents a point or direction in 3D space.
//(x, y, z) just 3 numbers
//x ? left/right
//y ? up/down
//z ? forward/backward

//Vector3 position = new Vector3(2, 5, 1);

//This means:

//2 units to the right
//5 units up
//1 unit forward
//Vector3.right is shortcut for new Vector3(1, 0, 0)


//Common built-in directions
//Vector3.right ? (1, 0, 0)
//Vector3.left ? (-1, 0, 0)
//Vector3.up ? (0, 1, 0)
//Vector3.down ? (0, -1, 0)
//Vector3.forward ? (0, 0, 1)
//Vector3.back ? (0, 0, -1)
//Vector3.zero ? (0, 0, 0)





// OR 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScript : MonoBehaviour
{


    Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }
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
            transform.position = startPosition;
        }
    }
}

//Explaination
//Stores the object’s starting position At the beginning (Start() runs once)
//Resets back to that exact position when space is pressed


//Code 1 ? “Go to the center of the world”
//Code 2 ? “Go back to where you started”
//Even in Code 2, you're restoring a world position, not local position
//The real difference
//It’s not which space is used.
//It’s what value you assign


//Code 1
//transform.position = Vector3.zero;
//You are assigning a fixed world position
//Always (0, 0, 0) no matter what
//Result:
//“Go to the center of the world”


//Code 2
//z = transform.position; // saved at Start
//transform.position = z;
//You are assigning a stored world position
//That value depends on where the object started
//Result:
//“Go back to where you originally were (in world space)”


// the real difference
//Aspect Code 1	Code 2
//Space used	World	World
//Value	Constant (0,0,0)	Saved starting position
//Behavior	Always same spot	Depends on spawn position

//Your two scripts differ because:
//One uses a hardcoded value
//One uses a stored value
//The world vs local difference only becomes visible when:
//The object has a parent
//Or the parent moves