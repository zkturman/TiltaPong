# <p align="center">TiltaPong</p>
<p align="center">A recreation of Pong, but with a couple of 'twists'</p>

## Table of Contents
0. [Before Reading](#BeforeReading)
1. [Project Overview](#ProjectOverview)
1. [Release](#Release)
    - [Where to Play](#WhereToPlay)
    - [Update Schedule](#UpdateSchedule)
1. [How to Contribute](#HowToContribute)
1. [Project Planning](#ProjectPlanning)
1. [Design Overview](#DesignOverview)
1. [Tools Overview](#ToolsOverview)

## <a name="BeforeReading"></a> Before Reading

This is a demo project for Popped Corn, a collaborative game development project for the Bristol Game Creators' Club. This paragraph and the [Tools Overview](#ToolsOverview) will be the only time I reference this being a demo project. Everything else will be simulated as if a real project. You may proceed! :)

## <a name="ProjectOverview"></a> Project Overview

Welcome to the TiltaPong repository! TiltaPong is a modern take on the classic arcade game, Pong, but with a couple of unique game mechanics. In addition to the regular back and forth, players will need to incorporate additional strategy with the ability to rotate the entire playing field! Players can also gain an advantage by adding extra power when returning the ball. While the game may feel familiar, new features will create a fun challenge for players. Before facing in-person competitors online, players can enjoy either a more casual experience or intense practice with the built in computer player. Due to its lightweight design and easy controls, TiltaPong is a modern-day arcade game that can be enjoyed by all.

## <a name="Release"></a> Release

### <a name="WhereToPlay"></a> Where to Play

TiltaPong is intended to release on Itch.io. The release window is the end of **November 2022**.

### <a name="UpdateSchedule"></a> Update Schedule

Following release, TiltaPong will enter ongoing maintenance for approximately three months. New features and bug fixes will be applied on a monthly basis. These features will be documented in [the roadmap](https://docs.google.com/spreadsheets/d/1IkqW6ugz-nVmIMVWQwWdWx6HQyx1fmjXpYGbteyWGx0/edit?usp=sharing).

## <a name="HowToContribute"></a> How to Contribute

If you are planning to contribute to TiltaPong there are plenty of areas to help out. If you're looking for tasks to complete, take a look at the [project planning](#ProjectPlanning) section where you can find our current milestones and tasks. To make changes or updates to the project head on over to our [contribution guide](Contributing.md).

## <a name="ProjectPlanning"></a> Project Planning

TiltaPong is being managed using Agile methodologies, and is utilising a roadmap for important feature development. The [current roadmap](https://docs.google.com/spreadsheets/d/1IkqW6ugz-nVmIMVWQwWdWx6HQyx1fmjXpYGbteyWGx0/edit?usp=sharing) focused on the new core gameplay mechanics:

![image](ProjectManagement/Roadmap_v1.png)

Each major feature listed in the Roadmap is an Epic that is broken down into smaller tasks and managed using sprints:

![image](ProjectManagement/13SepSprint.png)

Sprints are tracked and managed using [Trello](https://trello.com), and a link to the live [Kanban Taskboard](https://trello.com/invite/b/NYpFjTD3/0ef2224536b68d6acf466df171f4d408/sprint-tasks) is found here (requires a Trello account to view).

## <a name="DesignOverview"></a> Design Overview

The game design for TiltaPong is documented within its [design document](https://docs.google.com/document/d/1BxIRuREkCNnnhHKFHiHDU0i9Xp5bomv3vNINLLLVrhU/edit?usp=sharing). The design document details design decisions for the game, including game mechanics, controls, art direction, etc. The design document is completed dynamically based on the current roadmap. Only designated authors can edit the text of the document, but anyone can add comments. Game design will also be tracked in Google Sheets when identifying configurations of mechanics that are optimal for both fun and challenge.

In addition to the design document, wireframe prototypes and user flow diagrams for the project are presented in [the following document](Design/README.md). In combination, these elements are used as the foundation for the MVP.

Wireframes provide an initial plan for game UI:
![image](Design/SettingsWireframe.png)

User flow diagrams provide an initial plan for player behaviour:
![image](Design/GameplayFlow.png)

## Game Development Overview

TiltaPong is being developed using Unity and C#, and all code for the project is available under [Assets](Assets/), and is organised based on use case. Scenes were created from each wireframe prototype, and UI was developed using Unity's UI Toolkit. The UI Toolkit provides a method similar to web-application development for creating UI, and was chosen as an experimental comparison to Unity's other UI alternatives (conclusion, it's pretty slick!). We are currently developing the early-version prototype and will provide more technical details in the future:

![image](Documentation/InitialPrototypeWindow.png)

## Art Overview

Most art for this game will involve pixel art using a single pixel scaled to different sizes. This method be used for the following:
- Both player paddles
- Walls in the game/table area
- Ball

Slightly more sophisticated art will be used for UI/UX, but will still maintain a simple style. Any sprites will be created using Gimp, and both the .xcf and .png files will be source controlled here. All sprites can be found [here](Assets/Sprites).

## Sound Overview

Sound for TiltaPong will primarily come from the Unity Asset Store. Sound effects will be used to indicate both player input and game state. Thematic music will play throughout the game, but will differ depending on the player's scene.

## <a name="ToolsOverview"></a> Tools Overview

Below are all free tools that can be used for game development when working on Popped Corn projects. Other tools can be used as well, even paid tools. However, any content should always be stored in a way that allows others to access it for free.

- [Google Sheets](https://docs.google.com/spreadsheets) - Shareable roadmap creation and game mechanic logging
- [Trello](https://trello.com) - Sprint task tracking and sharing
- [Google Docs](https://docs.google.com) - Design document creation and sharing
- [Google Slides](https://docs.google.com/presentation) - Wireframe creation and sharing
- [diagrams.net](https://www.diagrams.net/) - Web-based diagram creation tools (can save directly to GitHub)
- [Git](https://git-scm.com/) - Free version control software
- [GitHub](https://github.com/) - Free hosted remote repositories for version control (as well as other things)
- [Unity](https://unity.com/) - Game engine and development tool primarily using C#
- [Unreal](https://www.unrealengine.com/en-US/) - Game engine and development tool primarily using Blueprints and C++
- [Godot](https://godotengine.org/) - Open-source game engine that uses its own language (GDScript), C#, or C++
- [Gimp](https://www.gimp.org/) - Free image editing software (includes more advanced tools than Paint, like layers and custom brushes)
- [Blender](https://www.blender.org/) - Free 3D modelling and animation software
- [Audacity](https://www.audacityteam.org/) - Free audio recording and editing
- [Cakewalk](http://www.cakewalk.com/) - Free audio recording, creation, and editing
