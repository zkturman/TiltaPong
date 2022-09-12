using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameEndUIController : MonoBehaviour
{
    private Button continueButton;
    private Button quitButton;
    private VisualElement rootVisualElement;
    private Label flavorText;
    private Label scoreText;
    [SerializeField] private string WinMessage;
    [SerializeField] private string LoseMessage;
    private string scoreTemplate = "{0} - {1}";

    private void OnEnable()
    {
        rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        continueButton = new SceneButton("ContinueButton", "HomeScene").GenerateButtonElement(rootVisualElement);
        quitButton = new QuitButton("QuitButton").GenerateButtonElement(rootVisualElement);
        flavorText = setupLabel("GameEndFlavorText", WinMessage);
        scoreText = setupLabel("FinalScore", scoreTemplate);
    }

    private Label setupLabel(string labelName, string labelText)
    {
        return new DynamicLabel(labelName).GenerateLabelWithText(rootVisualElement, labelText);
    }
}
