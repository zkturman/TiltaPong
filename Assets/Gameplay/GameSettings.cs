using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSettings
{
    public static int Difficulty { get; set; }
    private static readonly string DIFFICULTY_KEY = "Difficulty";
    public static int GameDuration { get; set; }
    private static readonly string GAME_DURATION_KEY = "GameDuration";

    public static int SoundFXVolume { get; set; }
    private static readonly string SOUND_FX_VOLUME_KEY = "SoundFXVolume";

    public static int MusicVolume { get; set; }
    private static readonly string MUSIC_VOLUME_KEY = "MusicVolume";

    public static int Brightness { get; set; }
    private static readonly string BRIGHTNESS_KEY = "Brightness";

    private static readonly int DEFAULT_SETTING_VALUE = 5;

    public static void SaveAllSettings()
    {
        PlayerPrefs.SetInt(DIFFICULTY_KEY, Difficulty);
        PlayerPrefs.SetInt(GAME_DURATION_KEY, GameDuration);
        PlayerPrefs.SetInt(SOUND_FX_VOLUME_KEY, SoundFXVolume);
        PlayerPrefs.SetInt(MUSIC_VOLUME_KEY , MusicVolume);
        PlayerPrefs.SetInt(BRIGHTNESS_KEY, Brightness);
        PlayerPrefs.Save();
    }

    public static void SaveSoundAndVisualSettings()
    {
        PlayerPrefs.SetInt(SOUND_FX_VOLUME_KEY, SoundFXVolume);
        PlayerPrefs.SetInt(MUSIC_VOLUME_KEY, MusicVolume);
        PlayerPrefs.SetInt(BRIGHTNESS_KEY, Brightness);
        PlayerPrefs.Save();
    }

    public static void LoadSettings()
    {
        Difficulty = loadKey(DIFFICULTY_KEY);
        GameDuration = loadKey(GAME_DURATION_KEY);
        SoundFXVolume = loadKey(SOUND_FX_VOLUME_KEY);
        MusicVolume = loadKey(MUSIC_VOLUME_KEY);
        Brightness = loadKey(BRIGHTNESS_KEY);
    }

    private static int loadKey(string keyName)
    {
        int keyValue;
        if (!PlayerPrefs.HasKey(keyName))
        {
            keyValue = DEFAULT_SETTING_VALUE;
        }
        else
        {
            keyValue = PlayerPrefs.GetInt(keyName);
        }
        return keyValue;
    }
}
