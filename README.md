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
