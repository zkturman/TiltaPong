using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class SceneButton : UIButton
{
    private string buttonName;
    private string nameOfLinkedScene;
    public SceneButton(string buttonName, string nameOfLinkedScene)
    {
        this.buttonName = buttonName;
        this.nameOfLinkedScene = nameOfLinkedScene;
    }

    public Button GenerateButtonElement(VisualElement rootVisualElement)
    {
        Button sceneButton = rootVisualElement.Q<Button>(buttonName);
        sceneButton.RegisterCallback<ClickEvent>(ev => openNewScene());
        return sceneButton;
    }

    private void openNewScene()
    {
        SceneManager.LoadScene(nameOfLinkedScene);
    }
}
