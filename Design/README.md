# <p align="center">TitlaPong Design Overview</p>

This README is designed to hold information regarding TiltaPong's design. Because the design is image and document heavy, it has been given a separate document to avoid clutter on the main page.

## Table of Contents

1. [Design Document]()
1. [UI and Behaviour Prototypes]()
    - [Home Scene]()
    - [Settings Scene]()
    - [Find Player Scene]()
    - [Gameplay Scene]()
    - [Gameplay Pause Menu]()
    - [Game End Scene]()
    - [Under Construction Scene]()

## Design Document

All mechanics and important design decisions are documented in [this document](https://docs.google.com/document/d/1BxIRuREkCNnnhHKFHiHDU0i9Xp5bomv3vNINLLLVrhU/edit?usp=sharing). Anyone is allowed to view and add comments to the document in Google Docs. However, only permitted authors have the security to edit the document. This security helps keep the documented information come from a few sources and can help keep the team informed about all updated decisions. The design document is updated dynamically when important decisions are made during ongoing development. As such, it is not a complete document until the game's development is finished.

## UI and Behaviour Prototypes

Below, wireframes for prototype UI are provides for various screens and menus located within the game. Due to the nature of a wireframe, these do not contain any game art. They are simply used to indicate the placement of different elements visible to the player.

In addition to wireframes, the intended player behaviour is documented using user flow diagrams. The following key can be used to discern the meanings of shapes and colours.
- Green circle - An action initiates the UI
- Blue rectangle - Actions that are descriptive and/or happen automatically
- Yellow diamond - A decision point in the behaviour made by the player or program
- Red circle - An action that ends the behaviour for a given UI and either leads to another UI or closes the game

In the following sections a 'scene' refers to a Unity Scene.

## Home Scene

The Home Scene is the scene the player encounters when launching the game application. The Home Scene is synonymous with 'start screen'.

Wireframe:

![image](HomeWireframe.png)

User Flow:

![image](HomeFlow.png)

## Settings Scene

The Settings Scene is where players will be able to modify settings outside of gameplay. Here they can change settings involve game behaviour, sounds, and visuals. Game behaviour settings can only be changed from this scene; they cannot be adjusted mid-game.

Wireframe:

![image](SettingsWireframe.png)

User Flow:

![image](SettingsFlow.png)

## Find Player Scene

![image](FindPlayerWireframe.png)

## Gameplay Scene

![image](GameplayWireframe.png)
![image](GameplayFlow.png)

## Gameplay Pause Menu

![image](GameplayPauseWireframe.png)
![image](GameplayPauseSettingsWireframe.png)
![image](GameplayPauseMenuFlow.png)


## Game End Scene#

![image](GameEndWireframe.png)
![image](GameEndFlow.png)

## Under Construction Scene

![image](UnderConstructionWireframe.png)
![image](UnderConstructionFlow.png)

[<p align="center">Back to Home</p>](../README.md)
