using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QuitButton : UIButton
{
    private string buttonName;
    public QuitButton(string buttonName)
    {
        this.buttonName = buttonName;
    }

    public Button GenerateButtonElement(VisualElement rootVisualElement)
    {
        Button quitButton = rootVisualElement.Q<Button>(buttonName);
        quitButton.RegisterCallback<ClickEvent>(ev => quitGame());
        return quitButton;
    }

    private void quitGame()
    {
        Application.Quit();
    }
}
