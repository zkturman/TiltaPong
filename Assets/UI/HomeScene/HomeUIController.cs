using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class HomeUIController : MonoBehaviour
{
    private Button playComputerButton;
    private Button playOnlineButton;
    private Button settingsButton;
    private Button quitButton;
    private VisualElement rootVisualElement;

    private void OnEnable()
    {
        rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        playComputerButton = setupSceneButton("PlayComputerButton", "GameplayScene");
        playOnlineButton = setupSceneButton("PlayOnlineButton", "UnderConstructionScene");
        settingsButton = setupSceneButton("SettingsButton", "UnderConstructionScene");
        quitButton = setupQuitButton("QuitButton");
    }

    private Button setupSceneButton(string buttonName, string sceneToOpen)
    {
        return new SceneButton(buttonName, sceneToOpen).GenerateButtonElement(rootVisualElement);
    }

    private Button setupQuitButton(string quitButtonName)
    {
        return new QuitButton(quitButtonName).GenerateButtonElement(rootVisualElement);
    }
}
