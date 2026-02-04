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