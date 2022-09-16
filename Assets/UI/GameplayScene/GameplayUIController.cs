using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class GameplayUIController : MonoBehaviour
{
    private Label scoreInfo;
    private string scoreFormat = "{0} - {1}";
    private VisualElement leftPlayerIndicator;
    private VisualElement rightPlayerIndicator;
    private VisualElement rootVisualElement;

    private void OnEnable()
    {
        rootVisualElement = GetComponent<UIDocument>().rootVisualElement;
        scoreInfo = new DynamicLabel("ScoreLabel").GenerateLabelWithText(rootVisualElement, scoreFormat);
        leftPlayerIndicator = initialiseIndicator("LeftPlayerIndicator");
        rightPlayerIndicator = initialiseIndicator("RightPlayerIndicator");
    }

    private VisualElement initialiseIndicator(string elementName)
    {
        VisualElement indicator = rootVisualElement.Q<VisualElement>(elementName);
        indicator.visible = false;
        return indicator;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
