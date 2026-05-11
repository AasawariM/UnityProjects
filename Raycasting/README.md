# Raycast

## Reference
https://docs.unity3d.com/ScriptReference/Physics.Raycast.html


- A Raycast in Unity is a physics function that projects an invisible line (a "ray") from a specific point in a chosen direction. It returns a boolean (true or false) based on whether the ray intersects with a GameObject that has a collider component.
- The most common way to perform a raycast is using the Physics.Raycast method.

- raycast function is made up of 3 different parts
1. Ray
2. Raycast hit variable
3. Raycast function itself


` void Update() {
    // 1. Create a Ray (Origin and Direction)
    Ray ray = new Ray(transform.position, transform.forward);
    
    // 2. Variable to store hit data
    RaycastHit hit;

    // 3. Fire the Raycast
    if (Physics.Raycast(ray, out hit, 100f)) {
        // If it hits, 'hit' contains info like:
        Debug.Log("Hit " + hit.collider.name);
        Debug.Log("Point of impact: " + hit.point);
    }
} `

1. A Ray is simply a data struture in unity that represents an origin and a direction
* Origin: The starting Vector3 position in the scene/world that the ray will start from such as transform posotion of an object, for example. 
* Direction: A Vector3 representing the path the ray travels (usually normalized = typically vector is definition of direction and length whereas normalized vector or a unit vector is definitioin of direction only the length of vector is always 1).

2. Raycast hit variable is a data structure in unity that contains information about ray's collision with an object.
* out hit: A RaycastHit object that Unity populates with detailed information (distance, hit point, surface normal, transform) if a collision occurs.
* Max Distance: (Optional) Limits how far the ray travels to save performance.
* Layer Mask: (Optional) Allows the ray to ignore specific objects or only interact with certain layers (e.g., ignoring "Friendly" targets).

3. Raycast function: for Raycast function itself there are several versions of raycast from different classes than can each be used in very different ways.however, one of the common ways of using raycast is by using the physics class.
Physics.raycast allows you to check if a ray collides with another object in a scene and if it does saves the collision data to a raycast hit variable using the `out` keyword.
this `out` keyword allows a function to return additional information in above code its the raycast hit variable.
its often used when the return type of the function which is normallay how you get data back from a method when you call it, is already being used for something else.
in this case the return type of Physics.Raycast function is boolean value which returns true or false depending on if an object was hit.


## reference videos
https://www.youtube.com/watch?v=B34iq4O5ZYI
https://www.youtube.com/watch?v=cUf7FnNqv7U
https://www.youtube.com/watch?v=U4Ye6xkgzKI



## Common Use Cases
* Shooting Mechanics: Determining if a bullet hits an enemy instantly without using physical projectiles.
* Ground Checks: Checking if a player's feet are touching the "Ground" layer before allowing a jump.
* Object Interaction: Detecting what object the player is looking at when they press an "Interact" key.
* Line of Sight: Checking if an enemy AI can see the player without an obstacle in the way



## code workflow
Create invisible ray
        ↓
Shoot forward 10 units
        ↓
Did it hit something?
       / \
     YES  NO
      |    |
Draw yellow   Draw white
Print object  Print no hit

* note: Right now the ray is continous we need to limit it to be emitted on mouse click.
- Added mouse click raycast along with object destroy and color change functionality.

### reference
https://www.youtube.com/watch?v=aaYfoe9i5lY
https://discussions.unity.com/t/use-raycast-to-click-on-object/104242
https://www.youtube.com/watch?v=_yf5vzZ2sYE
