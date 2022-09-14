# TiltaPong
Recreation of Pong, but with a couple of 'twists'

## Table of Contents
0. [Before Reading](#BeforeReading)
1. [Project Overview](#ProjectOverview)
1. [How to Download and Run](#HowToDownloadAndRun)
1. [Project Planning](#ProjectPlanning)
1. [How to Download and Run](#HowToDownloadAndRun)
    - [Downloading the Project](#DownloadingTheProject)
        - [Using Git + Command Line](#UsingGit)
        - [Using SourceTree](#UsingSourceTree)
    - Running the Project
1. [Game Design Overview](#DesignOverview)
    - [Example Tools](#DExampleTools)
    - [Real Access Links](#DRealAccessLinks)

## <a name="BeforeReading"></a> Before Reading

This is a demo project for Popped Corn, a collaborative game development project for the Bristol Game Creators' Club. This paragraph and the [Tools Overview](#ToolsOverview) will be the only time I reference this being a demo project. Everything else will be simulated as if a realy project. You may proceed! :)

## <a name="ProjectOverview"></a> Project Overview

Welcome to the TiltaPong repository! TiltaPong is a modern take on the classic arcade game, Pong, but with a couple of unique game mechanics. In addition to the regular back and forth, players will need to incorporate additional strategy with the ability to rotate the entire playing field! Players can also gain an advantage on their opponents by adding extra power to the ball. While the game may feel familiar, these features will create new challenges for players. Before facing in-person competitors online, players can enjoy either a more casual experience or intense practice with the built in computer player. Due to its lightweight design and easy controls, TiltaPong is a modern-day arcade game that can be enjoyed by all.

## <a name="HowToDownloadAndRun"></a> How to Download and Run

### <a name="DownloadingTheProject"></a> Downloading the Project

#### <a name="UsingGit"></a> Using Git + Command Line

For this method, you will need to have Git installed on your computer. Git is a free source control software on this project. If not already installed on your computer, [it can be downloaded here](https://git-scm.com/).

1. Open either PowerShell or a terminal window
1. ```CD``` to the directory you want to store your copy of this project
1. Enter ```git clone https://github.com/zkturman/TiltaPong.git```
    - You may be prompted for credentials at this stage. You can set these properties using a [one-time command](https://git-scm.com/book/en/v2/Getting-Started-First-Time-Git-Setup).
      - ```git config --global user.name "John Doe"```
      - ```git config --global user.name "John Doe"```
    - You may also be prompted for GitHub credentials or personal access token. Following [the steps here](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token) will help you configure Git to prevent this harassment.
      - Treat this token like a password and keep it CONFIDENTIAL.
      - Git should remember this token once you successfully complete an action using the token and close the terminal.

#### <a name="UsingSourceTree"></a> Using SourceTree

For this method, you will need to have SourceTree installed on your computer. SourceTree is a free Git GUI (as in you don't need the command line). [It can be downloaded here.](https://www.sourcetreeapp.com/) If you haven't already installed Git, you will need to install it as well. [Git can be downloaded here.](https://git-scm.com/)

1. Open SourceTree
1. Open a new tab and click the Clone button
1. In 'Source Path', enter ```https://github.com/zkturman/TiltaPong.git```
    - Note: this can be copied above by clicking the green Code button and copying the HTTPS URL
1. In 'Destination Path', enter the location on your computer you want this repository to be copied into
1. In 'Name', enter the name your want for your local project folder. E.g., TiltaPong

### <a name="RunningTheProject"></a> Running the Project

To run this project, you will need UnityHub installed on your computer. [It can be downloaded here.](https://unity.com/download) Once downloaded, you will need to download Unity version 2021.3.9f1. To install this version, follow these steps:

1. Open UnityHub
1. Click the Installs tab (on the left)
1. Click the Install Editor button
1. Locate version 2021.3.9.f1 in the Official Releases tab
1. Click the Install button

To open the TiltaPong project:

1. Open UnityHub
1. Click the Projects tab on the left (if not already selected)
1. Click Open >> Add Project from Disk
1. Select your TiltaPong folder
1. Click Add Project
1. If the project does not open automatically, click the TiltaPong row in UnityHub to open the project.

Currently, there are no special run or build instructions. If you would like to run the game from the start, follow these steps:

1. Navigate to the Assets\\Scenes\\ in Unity
1. Double click HomeScene
1. Click the Play button at the top of the Unity window

## <a name="ProjectPlanning"></a> Project Planning

TiltaPong is being managed using Agile methodologies, and is utilising a roadmap for important feature development. The [current roadmap](https://docs.google.com/spreadsheets/d/1IkqW6ugz-nVmIMVWQwWdWx6HQyx1fmjXpYGbteyWGx0/edit?usp=sharing) focused on the new core gameplay mechanics:

![image](ProjectManagement/Roadmap_v1.png)

Each major feature listed in the Roadmap is an Epic that is broken down into smaller tasks and managed using sprints:

![image](ProjectManagement/13SepSprint.png)

Sprints are tracked and managed using [Trello](https://trello.com), and a link to the live [Kanban Taskboard](https://trello.com/invite/b/NYpFjTD3/0ef2224536b68d6acf466df171f4d408/sprint-tasks) is found here (requires a Trello account to view).

## <a name="DesignOverview"></a> Game Design Overview



### <a name="DRealAccessLinks"></a> Real Access Links
  - [Design Document](https://docs.google.com/document/d/1BxIRuREkCNnnhHKFHiHDU0i9Xp5bomv3vNINLLLVrhU/edit?usp=sharing)
  - [Wireframe](https://docs.google.com/presentation/d/1e7tkWTWqtS5WHfBYMAKRvkrHDbI6QfcKw610GEsoQYo/edit?usp=sharing)

## Game Development Overview

## Art Overview

## Sound Overview

### <a name="PMExampleTools"></a> Example Tools

- [Google Sheets](https://docs.google.com/spreadsheets) - Roadmap creation and sharing
- [Trello](https://trello.com) - Sprint task tracking and sharing

### <a name="DExampleTools"></a> Example Tools

- [Google Docs](https://docs.google.com) - Design document creation and sharing
- [Google Slides](https://docs.google.com/presentation) - Wireframe creation and sharing
- [Google Sheets](https://docs.google.com/spreadsheets) - Shareable numbers and stuff for mechanics
- [diagrams.net](https://www.diagrams.net/) - Web-based diagram creation tools (can save directly to GitHub)

### Example Tools (development)
- [Git]() - Free version control software
- [GitHub]() - Free hosted remote repositories for version control (as well as other things)
- [Unity]() - Free game engine and development tool primarily using C#
- [Unreal]() - Free game engine and development tool primarily using Blueprints and C++

### Example Tools (art)
- [Gimp]() - Free image editing software (includes more advanced tools than Paint, like layers and custom brushes)
- [Blender]() - Free 3D modelling and animation software
- [Unity]() - Free animation software for 2D and 3D

### Example Tools
- [Audacity]() - Free audio recording and editing
- [Cakewalk]() - Free audio recording, creation, and editing
