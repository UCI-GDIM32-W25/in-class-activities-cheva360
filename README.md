# GDIM32 In Class Activities

# W1

## Activity 1
Advice:
- Gauge how much time it will take to make the minigame homework; some may take longer.
- Look for help in your table mates, do not be shy!
- Looking at Unity documentation for help with implementation and function

## Activity 2
Q1: What is the value of x after these lines of code?

- x = 10

Q2: What is the value of x after these lines of code?

- x = 2

Q3: What do these lines of code do?

- Every frame, print in console "hello world"

Q4: What kind of classes are the Update and Debug.Log methods usable in? I.e., what should replace the ???s ?

- "MonoBehavior"

Q5: What do these lines of code do?

- 10 is the argument put for the PrintMessage functions paremeter printing in the console "x = 10"

Q6: What are the name & purpose of these highlighted lines of code?

- 10 is the argument of the function which can be changed and the parenthesis is what the debug is logging in the console. In this case it takes the argument through the paremeter and prints x = the integer put as the argument.

Q7: What's wrong with this code?

- The code is not properly calling the transform variable. This would give an error.
 

Q8: What should we change in the highlighted code to fix this?

- Replace the Transform with _playerTransform as Transform is the class, not the name of the variable.

## Activity 3
- [HW 1 Link](https://docs.google.com/document/d/1ZloeI2O3HLCZUm7UvvfKdylog4EuKHg3eZPcW1Tevz0/edit?usp=sharing)

# W2

Drawing image: ![W2 Drawing](https://simp6.selti-delivery.ru/images3/MG2PenguinModelbd73228ade54a69e.png)

# W3
## Activity 0-2
Kaleb Reyes is my partner.

## Activity 3 Drawing
<img width="3306" height="2556" alt="birdMG3" src="https://github.com/user-attachments/assets/58e834fe-3a75-4f06-b471-5a3a6ff9c955" />

# W4
### Activity 0
Kaleb Reyes is my partner.

### Activity 1 
When multiple locators are in the project, every instance of the locator script is deleted except one. This is so that only one instance of the script is in the scene at a time, to avoid any issues. (singleton)

### Activity 2
<img width="2138" height="1448" alt="Blank document" src="https://github.com/user-attachments/assets/0ec02bd7-1073-46ac-995e-12c88ef47618" />


### Activity 3
[Github Commit](https://github.com/UCI-GDIM32-W25/HW4/commit/631ba7068582efe6b948ea5c96367868c24007a8)
- Added pipe instantiation, bird jumping, and pipe destroy offscreen.


# W5

### Activity 1

I think the design is pretty solid and I would only change having the durability variable in the Item class instead of being defined individually in each subclass.


### Activity 2

In the second demo, the Model is represented by the ScriptableObjects that hold the data for the items and dialogue, the View is represented by the visual elements in the scene such as the sprites, UI, and most importantly the dialogue, and the Controller is represented by the player input scripts (spacebar, wasd) for controlling the character and showing inventory.

### Activity 3

Scenario 1 (rhythm game))
- Instantiating note prefabs pulling from scritpable objects for variables such as speed, size, color, and sprite.

Scenario 2 (team shooter)
- Model
	- Stats for abilities, health, ammo, etc depencing on hero chosen
- View
	- UI elements for health and ammo and VFX for abilities
- Controller
	- User input for movement and shooting abilities

Scenario 3 (farming sim, chosen scenario)

Inheritance with polymorphism
- If any items or objects have different types of behavior (for example a rock triggers an event when hit,) override over parent behavior


Basic parent class, abstract class, and/or interface
- Inheritance for general usable things interfaces for "plantable, harvestable, destroyable, etc."


Finite State Machine with C# enums
- Different animation states of players and items as well as Enum states for the behaviors of the player.

Singleton
- GameController/Locator for events and connecting systems

ScriptableObjects
- For each item if they have different variables which should be tuned in inspector

Model-View-Controller with C# events
- Singleton GameController for events and subscriptions (Controller), Scriptable objects and variables of items for data (model), and animations, spriterendering, and particle effects (view)


### Activity 4

Jess Tran, Kaleb Reyes, Sebastian Magana

[Final Project Proposal](https://docs.google.com/document/d/11WOaLqc5etO8rKHDXbb_FdNeKd7ZzC0tJGFpK8PWQyE/edit?usp=sharing)


# W6

### Alt Activity 1, Narrative Writing with Freelance Senior Cory Lanham

Cory talked about his experience in narrative writing both as a freelance writer and as a narrative designer for games.

Cory prioritized talking about how to get into the industry as a narrative designer and cited the following advice:
- Networking!! (how he got an entry level position)
- Have a portfolio of writing samples related to games (for example, writing a quest or dialogue for an existing game, and also how you believe it could have been improved)
- Be open to starting in a different position and working your way up, you can start as a QA tester before moving into narrative design (but as mentioned in the talk with the Senior Recruiter for Obsidian, Josh Huang, its important to not directly apply as a QA tester with the sole purpose of moving up, as it can be seen as disingenuous)
- Be open to freelance work, as it can be a good way to build your portfolio and get experience (and also because getting a full time industry position is extremely difficult at the moment, he is currently working freelance.)

I also asked him a question about his favorite writing pieces he has done, and he cited his work on "The Lone Echo" 1 and 2, as well as his unpublished campaign for Dreadnaught, which he worked on in Germany. 

### Alt Activity 2, Technical Art @ Secret Door with Stephen Coan

Stephen talked about what technical art is and how it is used in game development, as well as his experience.

He described technical artists as responsible for:
- Shader writing and graphs
- VFX
- Rigging and animation
- Tools development
- and very importantly, optimization.

He also gave a demo on optimization, talking about how designers sometimes leave in a lot of unnecessary objects in the scene which can cause performance issues, and showed a quick example on how to use the profiler and RenderDoc to find a bottleneck.

In his experience, he specifically cited how he had to optimize a game originally meant to publish only on PC to be able to run on Nintendo Switch, which required a lot of optimization to run at a lower memory cap. 

I also asked him a question about if technical art is only applicable to later stages of development, and he said that it is important to have technical artists in regards to shader graphs, VFX, and early tools developments in pre-production and early production. Of course with things like rigging and animation, and optimization, it plays more of a role in later stages of development.


# W7

### Activity 1


Raycasts / Gizmos
- Used for checking the surface normal for the Player
- Used to check if the player is grounded
- Raycasts for the ducks vision (if blocked by trees)

Vectors
- Translating the duck position normalized towards the player 
- RotateTowards for the duck to face the player



### Activity 2

Sebastian Magana, Kaleb Reyes, Jess Tran


### Activity 3

Breakdown chart:


### Activity 4
[Trello link](https://trello.com/invite/b/69951f944f330958a4e6bf2f/ATTIb590dee498bae9e16078073fb9b8e6017C94F692/goofy-goobers-final-tasks)

## Activity 5

[Commit](https://github.com/lindenreid/GDIM32-Final/commit/5d21622676c7559f7e3f689b9d9ddd8b92f697b3)
- Changed player movement from tutorial script to personal script (rigidbody velocity), and added IsGrounded with raycast.


# W8

### Activity 1 
Post Processing Demo:

Post processing effects are shaders that affect the look of your entire scene
- ADD POST PROCESSING PACKAGE** in the unity registry
- Bloom
- Color grading!!
- Vignette
- Depth of Field
- Lens Distortion

**Unity packages and Post Processing packages are fine to use for project!** 
Add to unity from the unity asset store, then package manager.


### Activity 2 
Group Attendance

Sebastian Magana, Kaleb Reyes, Jess Tran

### Activity 3
Playtest Notes

- Player movement is good and responsive
- Sprint bar and sprint depletion works
- Jumped off world, need to add terrain and boundaries
- Itch description for controls is good, need to add click to interact when implemented

### Activity 4 
Task Check In

Scope is okay, needs a bit more speed
- Working on importing psx tree models into the scene

### Activity 5

[Commit](https://github.com/lindenreid/GDIM32-Final/commit/fa46a9d72b8dd78350c3ddd642aa13e207afa284)

# W9

### Activity 1

Branching dialogue demo

- Different dialogue options and AMOUNT of branches depending on which initial option you choose
- This is easily possible IF you have a scalable solution. Hardcoding makes this type of branching dialogue very difficult to implement and scale.
- You can also make returnable nodes in this flexible system with ScriptableObjects (foldback structure, necessary!!!)

For multiple npc buttons
- Code on canvas that hooks up the buttons to the currently talking NPC starting node, so that the same buttons can be used for multiple NPCs without having to hardcode to each NPC
- Singular DialogueManager that handles for multiple npcs


### Activity 2

Sebastian Magana, Kaleb Reyes, Jess Tran

### Activity 3
Playtest Notes

- He liked how it gave clear instructions to get the page
- Need to add indicator or highlight on the page so that its more clear where to go
- Indicator for the NPC that they are interactable 
- Add the rest of the content
- Add Compass for page navigation (Slenderman Tentacle)

### Activity 4
On our trello board we are about halfway through our tasks, (15/35) with the main framework code of the game done. Generally most of the rest of the content is regarding the actual creation of assets for the game, so we are well on track to finish on time. We may have to scope down for initial ideas about NPC behaviour, but overall we are still on track to finish with our initial tasks.

### Activity 5
[Commit](https://github.com/lindenreid/GDIM32-Final/commit/cf5e989fc2e97d3758b32294bbd543595ddb694f)

- Allowing the player to interact with different NPCs with seperate names and dialogue trees.


# W10

### Activity 1

Sebastian Magana, Kaleb Reyes, Jess Tran

### Activity 2 
Playtesting notes

Mac
- White Screen on shader (now fixed!!)

General
- Make the NPC's from gray boxes to actual npcs
- Door should be more apparent to the player
- Dialogue choice after quest is finished werent properly showing
- Arrow should be on top layer


### Activity 3

May need to lower the scope for my tasks (3d assets), a bit behind on schedule, but still fit to finish the game on time
