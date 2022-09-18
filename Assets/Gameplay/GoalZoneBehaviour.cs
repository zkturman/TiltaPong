using UnityEngine;

public class GoalZoneBehaviour : MonoBehaviour
{
    [SerializeField] PlayerBehaviour playerBehaviour;
    [SerializeField] RoundManager roundStatus;

    private void Awake()
    {
        if (playerBehaviour == null)
        {
            playerBehaviour = transform.parent.GetComponentInChildren<PlayerBehaviour>();
        }
    }

    public void ScorePoint()
    {
        playerBehaviour.IncrementScore();
        roundStatus.SetNextReturningPlayerID(playerBehaviour.ID);
        roundStatus.EndRound();
    }
}
