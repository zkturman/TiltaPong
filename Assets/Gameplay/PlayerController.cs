using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, PaddleController
{
    private KeyCode[] RelativeUpKeys = {KeyCode.W, KeyCode.UpArrow};
    private KeyCode[] RelativeDownKeys = {KeyCode.S, KeyCode.DownArrow};
    private KeyCode[] PauseKeys = { KeyCode.Escape };
    public PlayerBehaviour PlayerBehaviour { get; set; }

    private void Awake()
    {
        PlayerBehaviour = GetComponent<PlayerBehaviour>();
    }

    private void Update()
    {
        if (IsRelativeUpInputPressed())
        {
            HandleRelativeUpInput();
        }
        else if (IsRelativeDownInputPressed())
        {
            HandleRelativeDownInput();
        }
        else if (IsPauseInput())
        {
            HandlePauseInput();
        }
    }

    public bool IsRelativeUpInputPressed()
    {
        return isPressedKeyInSet(RelativeUpKeys);
    }

    public bool IsRelativeDownInputPressed()
    {
        return isPressedKeyInSet(RelativeDownKeys);
    }

    public bool IsPauseInput()
    {
        return isPressedKeyInSet(PauseKeys);
    }

    private bool isPressedKeyInSet(KeyCode[] validKeys)
    {
        bool isValidKey = false;
        for (int i = 0; i < validKeys.Length; i++)
        {
            if (Input.GetKey(validKeys[i]))
            {
                isValidKey = true;
            }
        }
        return isValidKey;
    }

    public void HandleRelativeUpInput()
    {
        PlayerBehaviour.MovePaddleRelativelyUp();
    }

    public void HandleRelativeDownInput()
    {
        PlayerBehaviour.MovePaddleRelativelyDown();
    }

    public void HandlePauseInput()
    {

    }
}
