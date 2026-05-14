# Collision in unity
yt link referred : https://www.youtube.com/watch?v=qcGa_mzjc8Q
refer:
https://docs.unity3d.com/Manual/CollidersOverview.html
## compound Colliders
https://docs.unity3d.com/Manual/compound-colliders.html



# Meshes
https://docs.unity3d.com/Manual/mesh.html


# prefab
##  Explaination
In Unity, a **Prefab** is a reusable GameObject template.

Think of it like a “blueprint” of an object.

Instead of creating the same object again and again manually, you create it once and save it as a Prefab.

---

### Simple Example

Suppose you made:

* a car
* added wheels
* collider
* scripts
* materials

Now you want 20 same cars.

Without Prefab:

* You create everything 20 times manually.

With Prefab:

* Create once
* Drag it into the Project folder
* Reuse infinitely

---

### How Prefabs Work

You create a GameObject in the Scene.

Example:

* Car
* Enemy
* Bullet
* Door
* Coin

Then:

* Drag that GameObject into the Project window

Unity creates a blue prefab asset.

Now you can drag copies into scene anytime.

---

### Why Prefabs Are Important

Prefabs help with:

* Reusability
* Faster development
* Consistency
* Easy updates
* Game optimization workflow

---

### Example in Your Project

Your obstacle cars can become prefabs.

Instead of:

* copying cars manually

You can:

* make one obstacle car prefab
* drag multiple instances into scene

If you later change:

* collider
* color
* script

All prefab instances update automatically.

---

### Types of Things Usually Made as Prefabs

Common prefabs:

* Cars
* Doors
* Bullets
* Enemies
* Coins
* UI panels
* Weapons
* NPCs
* Buildings

---

### How to Create a Prefab

#### Method 1

1. Create GameObject in Scene
2. Configure it
3. Drag it into Project folder

Done.

---

### Prefab Indicators

In Hierarchy:

* Blue object = prefab instance

---

### Prefab Instance

When you drag prefab into scene:

* it becomes a prefab instance

Meaning:

* connected to original prefab

---

### Apply Changes

If you edit one prefab instance:
Unity asks:

* Apply changes to all?
* Or keep local changes?

---

### Example Workflow

```text id="0r5vdw"
Create Car
    ↓
Add script + collider
    ↓
Drag into Project folder
    ↓
Prefab created
    ↓
Drag multiple copies into scene
```

---

### Prefab vs Normal Object

| Normal Object      | Prefab              |
| ------------------ | ------------------- |
| Scene-only         | Reusable asset      |
| No template        | Blueprint/template  |
| Manual duplication | Easy reuse          |
| Hard to manage     | Centralized updates |

---

### Why Prefabs Matter in AR/VR

In AR/VR projects, prefabs are heavily used for:

* interactive objects
* spawned objects
* environment assets
* UI panels
* controllers
* enemies/items

You’ll use prefabs constantly in Unity development.

---

### Example Code Using Prefab

```csharp id="d7m1hn"
public GameObject bulletPrefab;

Instantiate(bulletPrefab, transform.position, transform.rotation);
```

This creates a copy of prefab during gameplay.

Used for:

* bullets
* enemies
* effects
* coins
* particles

---

### Prefab Reference
https://www.youtube.com/watch?v=1sYl18io3ZM