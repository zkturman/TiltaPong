using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UnderConstructionUIController : MonoBehaviour
{
    private Button continueButton;
    private Button quitButton;
    private VisualElement rootVisualElement;

    private void OnEnable()
    {
        rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        continueButton = new SceneButton("HomeButton", "HomeScene").GenerateButtonElement(rootVisualElement);
        quitButton = new QuitButton("QuitButton").GenerateButtonElement(rootVisualElement);
    }
}
