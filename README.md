# C# Unity Milestones

Below is a list of tasks that correspond roughly to the "Take Action" sections of [Learning C# by Developing Games with Unity 2020](https://www.packtpub.com/product/learning-c-by-developing-games-with-unity-2020-fifth-edition/9781800207806) by Harrison Ferrone. By mid-semester, everyone should...

- Understand what the task is asking
- Be able to do the task
- Make it clear through your actions you understand what's happening



## Contents

1. [Instructions](#Instructions)
1. [Chapter 1](#chapter-1) - Getting to Know Your Environment (9–21)
1. [Chapter 2](#chapter-2) - The Building Blocks of Programming (22–37)
1. [Chapter 3](#chapter-3) - Diving into Variables, Types, and Methods (38–64)
1. [Chapter 4](#chapter-4) - Control Flow and Collection Types (65–93)
1. [Chapter 5](#chapter-5) - Working with Classes, Structs, and OOP (94–119)
1. [Chapter 6](#chapter-6) - Getting Your Hands Dirty with Unity (120–148)
1. [Chapter 7](#chapter-7) - Movement, Camera Controls, and Collisions (149–175)
1. [Chapter 8](#chapter-8) - Scripting Game Mechanics (176–207)






## Instructions

1. Fork this repository (into your own Github account)
1. Complete each task below inside the sample project included in this repository
1. Check off each task as you complete it, creating files and adding content where prompted with ✏️ or  **??**
1. Commit and push your work after each chapter
1. After you finish, celebrate your C# proficiency! 🙌  


#### Notes...

- **RTM** - Sometimes I give the command you need and sometimes you have to read the documentation to find it.
- **Details** - Following the instructions, especially those with a ✏️
- **Reference** - If you get stuck compare your code with the book [source code](https://github.com/PacktPublishing/Learning-C-8-by-Developing-Games-with-Unity-2020)






## Chapter 1
Getting to Know Your Environment (9–21)

- [x] Open the reference manual for any component from inside Unity. Paste the link: **file:///C:/Program%20Files/Unity/Hub/Editor/2020.3.26f1/Editor/Data/Documentation/en/Manual/class-AudioListener.html**
- [x] Find the button to jump to the scripting reference the any reference manual page. Paste the link: **file:///C:/Program%20Files/Unity/Hub/Editor/2020.3.26f1/Editor/Data/Documentation/en/ScriptReference/AudioListener.html**
- [x] Search for the `Strings` class in [Microsoft's C# documents](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/). Paste the link: **https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/**


## Chapter 2
The Building Blocks of Programming (22–37)

- [x] Open the Unity project contained within this repo called "MilestonesProject"
- [x] Create Assets/Scripts/LearningCurve.cs
	- [x] Create C# variables with typeof `int`, `float`, `string`, and `bool`
	- [x] Add a single line, multi line, and summary comment to LearningCurve.cs
	- [x] Run the code in LearningCurve by attaching it to the Main Camera GameObject


## Chapter 3
Diving into Variables, Types, and Methods (38–64)

- [x] Update Assets/Scripts/LearningCurve.cs
	- [x] Variables
		- [x] Use access modifiers to make your variables explicitly `public` and `private`
		- [x] Use `Debug.Log` and `Debug.LogFormat` to log your variables to the console
		- [x] Concatenate strings using the `+` operator, and the string interpolation method `$`
	- [x] Methods
		- [x] Define a simple method with parameters
		- [x] Add a return type and return some data from a method  
		- [x] Use data returned from a method  
- [x] Explain some differences between public and private variables: **Public variables can be edited outside of the class by other classes and private variable need accessors to be changed outside of the class. Ex: if you were making a banking app and your class' balance was public it could be changed in the main function and you could have like -$10000 but if it was private you could create functions that prevent it from being accessed subtracting so much money it's negative etc...**


## Chapter 4
Control Flow and Collection Types (65–93)

- [x] Update Assets/Scripts/LearningCurve.cs
	- [x] Conditionals
		- [x] Write `if`, `else if`, and `else` statements
		- [x] Test for `true` and `!true` in a conditional
		- [x] Write a nested `if` statement
		- [x] Write a `switch` statement
	- [x] Collections
		- [x] ✏️ What will `arr[1]` return from this array `int[] arr = {'red','green','blue'};` ? : **green**
		- [x] Write an Array of the type `int[]`
		- [x] Write a List of the type `List<string>`
		- [x] Write a Dictionary of the type `Dictionary<string, int>`
	- [x] Loops
		- [x] Use a `for` loop to print a specific index of a `List<string>`
		- [x] Use a `foreach` loop to print all indexes of a `List<string>`
		- [x] Use a `foreach` loop to print the `KeyValuePair.Key` and `KeyValuePair.Value` of all indexes of a `Dictionary<string, int>`



## Chapter 5
Working with Classes, Structs, and OOP (94–119)

- Classes
	- [ ] ✏️ Explain the difference between reference and value type variables: **Reference types hold the address for the information and value types hold the actual value (Nodes in LinkedLists are the best example because they contain a .value which is the value and a .next which is the reference/address to the next value is in the list so you can see the difference in the 2 types of information being stored)**
	- [x] Create Assets/Scripts/Character.cs
		- [x] Create a `Character` class
		- [x] Create `string` and `int` fields inside the Character class
		- [x] Create a `Character()` constructor and populate the above fields with its parameters
	- [x] Update Assets/Scripts/LearningCurve.cs
		- [x] Instantiate two new Character objects `hero` and `heroine` from the `Character` class
		- [x] Print out each characters data
- [x] Structs
	- [x] Update Assets/Scripts/Character.cs
		- [x] Add a `Weapon` struct
		- [x] Create `string` and `int` fields inside the Weapon struct
		- [x] Create a `Weapon()` constructor and populate the above fields with its parameters
	- [x] Update Assets/Scripts/LearningCurve.cs
		- [x] Instantiate two new Weapon objects `huntingBow` and `warBow` from the `Weapon` struct
		- [x] Print out each weapons' data
- Child classes
	- [ ] Update Assets/Scripts/Character.cs
		- [ ] Add a `Paladin` child class of `Character`
		- [ ] Create a `Weapon` field inside the Paladin class
		- [ ] Create a `Paladin()` constructor that calls the `base()` constructor. Populate the weapon in a parameter
	- [ ] Update Assets/Scripts/LearningCurve.cs
		- [ ] Instantiate a new Paladin object `knight` from the Paladin class
		- [ ] Print the Paladin's name and weapon by overriding `PrintStatsInfo` in the base class
- Referencing objects
	- [ ] Update Assets/Scripts/LearningCurve.cs
		- [ ] Store a reference to the current game object's (Main Camera) `Transform` component using `GetComponent<>()`
		- [ ] Log a reference to the `localPosition` field of the Main Camera's `Transform`
		- [ ] Store a reference to the Light `GameObject` using `GameObject.Find()`
		- [ ] Store a reference to the Light's `Transform` component using `GetComponent<>()`
		- [ ] Log a reference to the `localPosition` field of the Light's `Transform`



## Chapter 6
Getting Your Hands Dirty with Unity (120–148)

- [ ] Use primitive cubes and move, rotate, and scale tools to create a level or "world" in Unity
- [ ] Add materials to primitives in Unity to change their color
- [ ] Use parenting and "empty objects" in the Hierarchy tab to organize your project
- [ ] Create, update, and use prefab game objects
- [ ] Create timeline animations by recording keyframes and editing curves in Unity
- [ ] Add and edit a particle system to a game object in Unity




## Chapter 7
Movement, Camera Controls, and Collisions (149–175)

- [ ] Movement
	- [ ] Understand the difference between a "position vector" and a "direction vector"
	- [ ] Capture keyboard input in C#
	- [ ] Move and rotate a game object using `Translate()` and `Rotate()` with direction vectors
- [ ] Camera Controls
	- [ ] Add a script to the main camera that follows and looks at the player
- [ ] Physics and Collisions
	- [ ] Use `FixedUpdate()` to control game objects using Unity's physics engine
	- [ ] Apply physics forces to a game object RigidBody using `MovePosition()`
	- [ ] ✏️ Q: Will a [collision detection](https://docs.unity3d.com/Manual/CollidersOverview.html) occur when a Kinematic Rigidbody Collider touches a Static Collider? : **??**
	- [ ] Use `OnCollisionEnter()` to check if a game object has run into another collider
	- [ ] Use `Destroy()` to remove a game object from the scene
	- [ ] Use `OnTriggerEnter()` and `OnTriggerExit()` to detect when two colliders start and stop touching





## Chapter 8
Scripting Game Mechanics (176–207)

- Character Control
	- [ ] Capture keyboard input in C# using the `enum` type and value `KeyCode.Space`
	- [ ] Use `AddForce()` to make a character jump
	- [ ] Use a `LayerMask` and a new "Ground" layer in Unity to determine if a character is "IsGrounded"
- [ ] Add a shooting mechanic
	- [ ] Create a "projectile" prefab that moves forward using `RigidBody.velocity`
	- [ ] Instantiate the projectile on click and destroy it after `3` seconds
- [ ] Create a GameManager
 	- [ ] Use `get` and `set` properties to return and assign properties that are used across the game
- [ ] Add a simple UI to inform the user of game state(s)
	- [ ] Add text to show the health and items counts to the user
	- [ ] Add a win condition to the game and display it in the UI
	- [ ] Use `Time.timeScale = 0` to pause the game
