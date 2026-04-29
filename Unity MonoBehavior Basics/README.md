** Official Documentation **
**https://docs.unity3d.com/Manual/**


# Unity First Person Player Movement

This project contains a basic first-person player controller built using Unity's CharacterController.

## Features

* WASD Movement
* Sprint (Shift)
* Jump (Space)
* Crouch (R)
* Mouse Look

## Requirements

* Unity editor version 2022.3

## Setup

1. Attach the script to a GameObject
2. Add a CharacterController component
3. Assign a Camera to `playerCamera`

## Controls

* W/A/S/D → Move
* Shift → Run
* Space → Jump
* R → Crouch
* Mouse → Look around




# Character Controller vs Rigidbody
## Character Controller
You control movement manually
Very smooth and precise
Used in FPS games
## Rigidbody
Physics-based movement
Uses forces, mass, collisions
Used for realistic objects
### Use Character Controller when you want:
FPS movement
Third-person movement
Tight, responsive controls
A Character Controller is a non-physics player movement system where you manually control movement, and Unity handles collisions for you.

# Class Declaration
`public class PlayerMovement : MonoBehaviour`
- Defines a script called PlayerMovement
- Inherits from MonoBehaviour → allows it to run in Unity (use Start(), Update(), etc.)

## MonoBehaviour

**https://docs.unity3d.com/Manual/class-MonoBehaviour.html**


-  you do not always need to use MonoBehaviour while defining a script for a player in Unity. While it is the default and most common approach, its use depends on whether the script needs to be attached directly to a GameObject or interact directly with the Unity scene lifecycle.
- When You MUST Use MonoBehaviour
  - 1. Attaching to a GameObject: If you want to drag the script onto a player GameObject in the Inspector, it must inherit from MonoBehaviour.
    2. Using Unity Lifecycle Methods: If you need to use Start(), Update(), FixedUpdate(), or OnCollisionEnter(), you must inherit from MonoBehaviour.
    3. Accessing Components: To use GetComponent<T>() or interact with components like Rigidbody or Animator directly within that script, MonoBehaviour is required.
- When You Should NOT Use MonoBehaviour
  - 1. Pure Data Structures/Logic: If the script is only storing player stats (e.g., health, speed, ammo) or handling mathematical calculations, a standard C# class or struct is more efficient.
- Example: Player System Split
 - A common, optimized approach is to split the player system: 
 - PlayerController.cs (MonoBehaviour): Attached to the GameObject, handles input and moves the character.
 - PlayerData.cs (No MonoBehaviour): A pure C# class that PlayerController uses to store health, movement speed, etc.  

# Public Variables (Editable in Inspector)
public Camera playerCamera;

Reference to the player’s camera (used for looking up/down).

public float walkSpeed = 6f;
public float runSpeed = 12f;

Movement speeds:

Walking = 6
Running = 12
public float jumpPower = 7f;

How strong the jump is.

public float gravity = 10f;

How fast the player falls.

public float lookSpeed = 2f;

Mouse sensitivity.

public float lookXLimit = 45f;

Limits vertical camera rotation (prevents flipping).

public float defaultHeight = 2f;
public float crouchHeight = 1f;

Player height:

Standing = 2
Crouching = 1
public float crouchSpeed = 3f;

Movement speed while crouching.

# Private Variables
private Vector3 moveDirection = Vector3.zero;

Stores movement direction (x = left/right, y = up/down, z = forward/backward).

private float rotationX = 0;

Stores vertical camera rotation.

private CharacterController characterController;

Reference to the CharacterController component.

private bool canMove = true;

Allows enabling/disabling movement.

# Start() — Runs Once
void Start()
characterController = GetComponent<CharacterController>();

Gets the CharacterController attached to the object.

Cursor.lockState = CursorLockMode.Locked;

Locks mouse to center of screen.

Cursor.visible = false;

Hides the cursor.

# Update Function
In Unity, the Update() function is the main loop that runs every frame.

In simple terms

Update() = “Do this again and again every frame while the game is running.”

What “every frame” means
If your game runs at 60 FPS, Update() runs 60 times per second
If it drops to 30 FPS → runs 30 times per second
Why it’s used

You use Update() for things that need to constantly check or change:

Player input (keyboard, mouse)
Movement
Camera rotation
Real-time updates
In your script

Inside Update():

It reads input (WASD, mouse, jump)
Calculates movement
Applies gravity
Moves the player
Rotates the camera

👉 All of this must happen continuously, so it’s inside Update().

Important detail

Because Update() runs every frame, you often use:

Time.deltaTime

👉 This makes movement smooth and consistent, regardless of FPS.
Update() is a function that runs every frame and is used for real-time game logic like input, movement, and camera control.


