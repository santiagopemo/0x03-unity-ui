# 0x02. Unity - Scripting
## Build
[Click her](https://santiagopemo.github.io/0x02-unity-scripting/) to watch the game
## Resources :books:
### Read or watch:

* [Unity Manual: Scripting Overview (Read sections from “Creating and Using Scripts” to “Understanding Automatic Memory Management”)]()
* [Scripts as Behavior Components]()
* [How to make a Video Game in Unity - Programming]()
* [How to make a Video Game in Unity - Movement]()
* [How to make a Video Game in Unity - Camera Follow]()
* [Vector Maths]()
* [What Makes Great Games Great?]()
* [Unity Manual]()
* [Unity Tutorials: Scripting]()
* [Unity Manual: Vector3]()
## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What are scripts in Unity and how are they created and used
* How to control GameObjects with scripts
* What is an event function and how are the most common ones used
* How to create and destroy GameObjects within scripts
* How to use namespaces to organize classes
* What are attributes and how to use them
* How to use Debug.Log()
* What is a vector
## Requirements :white_check_mark:
### General
* A README.md file, at the root of the folder of the project
* Use Unity’s default .gitignore in your project folder
* Push the entire repo 0x02-unity-scripting, including .meta files
* Scenes and project assets such as Materials must be named and organized as described in the tasks
## Tasks
### Mandatory :page_with_curl:
- [x] **[0. Ready player one](./Assets/maze.unity)** - Clone this repository containing a maze Unity project. You will build on this project by adding new GameObjects and scripts to create a playable game. This project should be pushed to its own repo called 0x02-unity-scripting, not within a subdirectory
- [x] **[1. Bust a move](./Assets/maze.unity)** - Movement should only be on the X and Z axes – the Player should not be able to jump
- [x] **[2. Camera ready](./Assets/maze.unity)** - Move the Main Camera to position (22, 26, 7). Create a new C# script in the Scripts directory called CameraController.cs
- [x] **[3. Insert coin](./Assets/maze.unity)** - Create a new Cylinder GameObject named Coin
- [x] **[4. Coin collecting](./Assets/maze.unity)** - Create a new C# script called Rotator.cs and attach it to Coin
- [x] **[5. Danger zone](./Assets/maze.unity)** - Create a new Plane GameObject named Trap
- [x] **[6. You've activated my trap card](./Assets/maze.unity)** - Add a new public int health variable to your PlayerController.cs script. Set the initial value of health to 5
- [x] **[7. The finish line](./Assets/maze.unity)** - Create a new Plane GameObject named Goal
- [x] **[8. Goaaaaaaaaaaal](./Assets/maze.unity)** - In PlayerController.cs, add to the existing void OnTriggerEnter(Collider other) function
- [x] **[9. Game over](./Assets/maze.unity)** - Create an Update() function within PlayerController.cs
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@Santiag11470161](https://twitter.com/Santiag11470161) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
