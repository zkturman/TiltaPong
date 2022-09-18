using UnityEngine;
using UnityEngine.UIElements;
public class GameplayUIController : MonoBehaviour
{
    private Label scoreInfo;
    private string scoreFormat = "{0} - {1}";
    private bool isFirstPlayerTurn = true;
    private VisualElement leftPlayerIndicator;
    private VisualElement rightPlayerIndicator;
    private VisualElement rootVisualElement;
    private RoundManager roundManager;

    private void OnEnable()
    {
        roundManager = FindObjectOfType<RoundManager>();
        rootVisualElement = GetComponent<UIDocument>().rootVisualElement;
        scoreInfo = new DynamicLabel("ScoreLabel").GenerateLabelWithText(rootVisualElement, scoreFormat);
        leftPlayerIndicator = initialiseIndicator("LeftPlayerIndicator");
        rightPlayerIndicator = initialiseIndicator("RightPlayerIndicator");
        setTurnIndicator();
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
        if (scoreInfo.text != makeStatString())
        {
            scoreInfo.text = makeStatString();
        }
        if (roundManager.IsFirstPlayerTurn() != isFirstPlayerTurn)
        {
            isFirstPlayerTurn = roundManager.IsFirstPlayerTurn();
            setTurnIndicator();
        }
        
    }

    private string makeStatString()
    {
        int firstPlayerScore = roundManager.GetScoreOfIndexedPlayer(0);
        int secondPlayerScore = roundManager.GetScoreOfIndexedPlayer(1);
        return string.Format(scoreFormat, firstPlayerScore, secondPlayerScore);
    }

    private void setTurnIndicator()
    {
        if (isFirstPlayerTurn)
        {
            leftPlayerIndicator.visible = true;
            rightPlayerIndicator.visible = false;
        }
        else
        {
            leftPlayerIndicator.visible = false;
            rightPlayerIndicator.visible = true;
        }
    }
}
