using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SaveButton : UIButton
{
    private string buttonName;
    private bool saveAll;
    public SaveButton(string buttonName, bool saveAll)
    {
        this.buttonName = buttonName;
        this.saveAll= saveAll;
    }

    public Button GenerateButtonElement(VisualElement rootVisualElement)
    {
        Button saveButton = rootVisualElement.Q<Button>(buttonName);
        if (saveAll)
        {
            saveButton.RegisterCallback<ClickEvent>(ev => saveAllSettings());
        }
        else
        {
            saveButton.RegisterCallback<ClickEvent>(eve => saveSoundAndVisualSettings());
        }
        return saveButton;
    }

    private void saveAllSettings()
    {
        GameSettings.SaveAllSettings();
    }

    private void saveSoundAndVisualSettings()
    {
        GameSettings.SaveSoundAndVisualSettings();
    }
}
