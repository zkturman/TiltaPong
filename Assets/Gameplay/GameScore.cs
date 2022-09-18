using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScore
{
    public int endScore = 5;
    public static bool IsGameVictory { get; private set; }
    private static bool isGameVictory = false;

    public GameScore()
    {

    }
}
