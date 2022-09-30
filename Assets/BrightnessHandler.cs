using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class BrightnessHandler : MonoBehaviour
{
    [SerializeField]
    private PostProcessVolume globalVolume;
    [SerializeField]
    private float maximumBrightness = 2.5f;

    // Update is called once per frame
    void Update()
    {
        globalVolume.sharedProfile.GetSetting<ColorGrading>().postExposure.value = (GameSettings.Brightness / 2f) - maximumBrightness;
    }
}
