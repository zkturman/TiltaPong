using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class SettingsUIController : MonoBehaviour
{
    private SliderInt difficultySetting;
    private SliderInt durationSetting;
    private SliderInt soundFXVolumne;
    private SliderInt musicVolume;
    private SliderInt brightnessSetting;
    private Button homeButton;
    private Button saveButton;
    private VisualElement rootVisualElement;

    private void OnEnable()
    {
        rootVisualElement = GetComponent<UIDocument>().rootVisualElement;
        difficultySetting = new SettingsSlider("DifficultySlider").GenerateSliderElement(rootVisualElement); 
        durationSetting = new SettingsSlider("GameDurationSlider").GenerateSliderElement(rootVisualElement);
        soundFXVolumne = new SettingsSlider("SoundFXVolumeSlider").GenerateSliderElement(rootVisualElement);
        musicVolume = new SettingsSlider("MusicVolumeSlider").GenerateSliderElement(rootVisualElement);
        brightnessSetting = new SettingsSlider("BrightnessSlider").GenerateSliderElement(rootVisualElement);
        homeButton = new SceneButton("HomeButton", "HomeScene").GenerateButtonElement(rootVisualElement);
        saveButton = new SaveButton("SaveButton", true).GenerateButtonElement(rootVisualElement);
    }

    private void syncSlidersToSettings()
    {
        difficultySetting.value = GameSettings.Difficulty;
        durationSetting.value = GameSettings.GameDuration;
        soundFXVolumne.value = GameSettings.SoundFXVolume;
        musicVolume.value = GameSettings.MusicVolume;
        brightnessSetting.value = GameSettings.Brightness;
    }

    // Update is called once per frame
    void Update()
    {
        syncSettingsToSliders();
    }

    private void syncSettingsToSliders()
    {
        GameSettings.Difficulty = difficultySetting.value;
        GameSettings.GameDuration = durationSetting.value;
        GameSettings.SoundFXVolume = soundFXVolumne.value;
        GameSettings.MusicVolume = musicVolume.value;
        GameSettings.Brightness = brightnessSetting.value;
    }
}
