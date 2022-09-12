using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class DynamicLabel
{
    private string labelName;
    public DynamicLabel(string labelName)
    {
        this.labelName = labelName;
    }

    public Label GenerateLabelWithText(VisualElement rootVisualElement, string labelCaption)
    {
        Label newLabel = rootVisualElement.Q<Label>(labelName);
        newLabel.text = labelCaption;
        return newLabel;
    }
}
