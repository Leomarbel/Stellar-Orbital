# Stellar
An Asymetrical Multiplayer Sparcefaring Roguelite

Summary

Starship Game is an rogue-lite asymmetrical co-operative shoot-em up game. 

Players must work together to ensure the ship survives its voyage through the stars! Each player takes one of 2 roles: the pilot and the mechanic. The pilot must shoot down enemies and avoid hazards while flying through space. Meanwhile, the mechanic has to perform vital functions to ensure the spacecraft is in ship shape, like loading ammunition, implementing upgrades and repairing damage the pilot has sustained in real time. Damage sustained by the pilot and errors made by the mechanic will affect both players. So they must be in sync if they want to survive their stellar odyssey.

**Setup**
THIS GAME REQUIRES 2 GAME INSTANCE TO PLAY!!! If you are just trying out on one PC, you can just open 2 applications by clicking on the .exe folder "StellarMS3.exe" twice.

**Instructions** (This is implemented in the game in future versions)
The overall goal of this game is to travel the most worlds as possible.

Pilot: (MAKE SURE TO TURN DOWN YOUR VOLUME, the sound effects may be loud)
You can freely move around using WASD and click the enemies to shoot. 

There are 2 types of enemies
Seeker: Small monsters that chase you down
Use your bullets to shoot them down and stay away from them.

Lurker: Invincible and partially invisibile monsters that are stationary and shoot multiple bullets.
You require a scan to reveal their hitboxes and shoot them down when the technician successfully performs the scan.

The goal of the pilot is to survive and collect sufficient boost points to warp to the next universe. (This is indicated by a progress bar below your HP)

The core gameplay loop requires you go communicate to your technician:
- Refill Ammo
- When to do scans
- When it is ready to travel to the next world

Technician:
You control a playable character in a ship and you complete tasks to assist your pilot. Press 'Z' to interact with events.

There are 3 types of events
1. Reloading Station
This is a rhythm based minigame where you reload the pilot's ammo by tapping the correct keys corresponding to the ammo lanes.
Press 'C' 'V' 'B' 'N' for the keys.

2. Scanning Station
This is the scanner to aid the pilot to reveal Lurkers and provides an AOE stun to the map.
You complete this station by typing 'ciphers' before they disappear.

3. Fire Extinguishing Event
When fire appear, you can interact with them (Press 'Z') to start the extinguishing minigame. To successfully complete this minigame, you control a green rectangle bar at the bottom of the screen with Left and Right Arrow Keys and ensure your bar is within a moving bar.

There is a progress bar on the top right that determine your progress to the next level. Once it is full, a button in the middle of the room will be lit up and pressing it would advance you into the next world.



Motivation

We love games for its social aspect, so we wanted to make a cooperative game that requires communication between players, so we want to make a game that can foster the same sense of satisfaction that comes from working together. We also love the design of “asymmetrical” multiplayer games like Puyo Puyo Tetris and Dead by Daylight, and wanted to see if we could apply the same concepts in a more cooperative environment.
Through this project, we also hope to gain more experience in the workflow for collaborating on a game development project, and to gain software engineering experience in game development. We also hope to use this as an opportunity to learn the tech stack for making games.

System design and Features

- **Rogue-lite**

    Monsters will be in randomly generated positions.


- **360 degrees movement of spaceship**

  
    Navigate through an unknown universe with monsters hiding in all directions of the player. 


- **Co-op player interaction and teamwork**

  
    There are two roles in the spacecraft, the pilot and the technician. The pilot controls the spacecraft, the technician maintains the spacecraft. Both parties have to work together to survive this chaotic universe.


- **Technician minigames**

  
    The technician has multiple tasks, reloading the pilot’s ammo, repairing the spacecraft, and engaging the spacecraft’s shield. Each task requires a different minigame to complete the tasks.


- **Duo screen integration**

  
    The game screen contains the navigation screen for the pilot and the workshop screen for the technician. Both players can do their tasks concurrently on the same screen.

- **Random generated monsters and locations**

  
    Each run will be uniquely different in terms of monsters and loot in the universe. Explore cautiously, no two universes are the same!


