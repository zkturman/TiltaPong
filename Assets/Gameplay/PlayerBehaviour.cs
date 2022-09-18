using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private int score = 0;
    public int ID { get; set; }
    public int Score
    {
        get => score;
    }

    public void IncrementScore()
    {
        score++;
    }
}
