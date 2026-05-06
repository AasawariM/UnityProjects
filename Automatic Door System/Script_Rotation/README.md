# Automatic Door System (Unity)

This project demonstrates a simple **automatic door system** built in Unity using C# scripting. The door opens and closes automatically based on player interaction.

---

##  Features

* Automatic door opening when player approaches
* Smooth door rotation using script
* Simple and reusable logic
* Basic player movement included

---

##  Built With

* **Unity** (Game Engine)
* **C#** (Scripting)

---

##  Project Structure

```
Assets/
│
├── Scenes/              # Main scene i.e SampleScene
├── Scripts/             # door_rotate.cs, PlayerMovement.cs
├── (Door Assets)        # Only required door and audio used
│
Packages/
ProjectSettings/
```

---

## How to Run

1. Open the project in Unity Hub
2. Load the scene from:

   ```
   Assets/Scenes/
   ```
3. Click **Play**
4. Move the player toward the door to see the automatic system in action

---

##  How It Works

* The door uses a script (`door_rotate.cs`)
* When the player enters a trigger zone:

  * Door rotates open
* When the player exits:

  * Door closes

---

## Assets Used

* A free wood door pack asset 

> Note: Full asset pack is not included to keep the project lightweight.

---

## Configuration
* Unity Version: 2022.3
* Template: 3D (Core)Render Pipeline: Built-in



* Scene Configuration
1. Add Player
2. Add Plane
3. Add Door 
4. Add Collider for door

1. Door Setup
Add your door GameObject (imported model from free wood door asset pack)
it will have Frame and Door(with knob)
Add Empty Object named collider in top door used
Add Box Collider
Enable Is Trigger (for detection zone if separate trigger not used)
Resize it to cover area in front of door
Attach script:
door_rotate.cs
add audio open and close from assets in inspector.
also add Door with knob (entire object) for door varible in inspector(door script)
add rigidbody  with Constraints all checked.

2. very important for door to move out from the door => remove mesh collider from the frame 


3. Player Setup
Create a player (Capsule or character)
Add: 
- Character Controller (gets added with script below)
- Script: PlayerMovement.cs
- Tag the player: Player
- give main Camera as Player Camera in inspector

## reference 
https://www.youtube.com/watch?v=cNrKc_tT7XE