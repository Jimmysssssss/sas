# Ready to Play Unity Game

This repository contains a small Unity 2021.3 project that you can open and play immediately. The goal is to roll a cube around the arena, collect glowing pickups, and chase a high score.

## Features

- **Instant gameplay** – press Play in the Unity editor and start collecting pickups.
- **Simple controls** – move with the WASD keys or arrow keys.
- **Dynamic pickups** – collectibles are spawned procedurally with a subtle rotation effect.
- **Clean project setup** – includes build settings, tags, and materials so everything is ready out of the box.

## Getting Started

1. Install [Unity 2021.3.33f1](https://unity3d.com/get-unity/download/archive) or a compatible 2021.3 LTS version.
2. Clone this repository and open the folder with Unity Hub or from the Unity editor.
3. Open `Assets/Scenes/MainScene.unity` if it is not already open.
4. Press the **Play** button in the toolbar to control the player cube and collect the spinning orbs.

### Controls

- **WASD / Arrow keys** – Move the cube around the arena.

### Building the Game

1. Open the **Build Settings** window (`File > Build Settings`).
2. Ensure that `Assets/Scenes/MainScene.unity` is checked in the build list.
3. Choose your target platform (PC/Mac/Linux Standalone by default).
4. Click **Build and Run** to produce a playable build.

## Project Structure

```
Assets/
  Materials/
    Player.mat           # Material used by the player cube
  Scenes/
    MainScene.unity      # Ready-to-play scene
  Scripts/
    GameManager.cs       # Spawns pickups at runtime
    PickupRotator.cs     # Spins pickups for visual flair
    PlayerController.cs  # Handles player input and scoring
Packages/
  manifest.json          # Unity package manifest
ProjectSettings/         # Essential Unity project settings (tags, build list, version)
```

Enjoy the game and customize it however you like!
