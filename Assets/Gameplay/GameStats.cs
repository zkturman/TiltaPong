using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    public static int ThisPlayerScore { get; private set; }
    private static int thisPlayerScore = 0;
    public static int OpposingPlayerScore { get; private set; }
    private static int opposingPlayerScore = 0;
    public static bool IsGameVictory { get; private set; }
    private static bool isGameVictory = false;
}
