using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SettingsSlider
{
    private string sliderName;

    public SettingsSlider(string sliderName)
    {
        this.sliderName = sliderName;
    }

    public SliderInt GenerateSliderElement(VisualElement rootVisualElement)
    {
        SliderInt settingControl = rootVisualElement.Q<SliderInt>(sliderName);
        return settingControl;
    }
}
