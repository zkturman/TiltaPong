using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public interface UIButton
{
    public Button GenerateButtonElement(VisualElement rootVisualElement);
}
