using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundManager : MonoBehaviour
{
    public int endScore = 3;
    private int returningPlayerID;
    private int firstPlayerID;
    private PlayerBehaviour[] allPlayers;
    [SerializeField]
    private GameObject ballPrefab;
    private const int MAX_PLAYERS = 2;
    private void Awake()
    {
        allPlayers = FindObjectsOfType<PlayerBehaviour>();
        for (int i = 0; i < allPlayers.Length; i++)
        {
            allPlayers[i].ID = i;
        }
        firstPlayerID = getFirstPlayerID();
        randomiseStartingID();
        DontDestroyOnLoad(gameObject);
    }

    private void randomiseStartingID()
    {
        returningPlayerID = Random.Range(0, MAX_PLAYERS);
    }

    private int getFirstPlayerID()
    {
        int firstPlayerID = 0;
        bool isFirstPlayer = allPlayers[firstPlayerID].TryGetComponent(out PlayerController component);
        if (!isFirstPlayer)
        {
            firstPlayerID = 1;
        }
        return firstPlayerID;
    }

    public int GetScoreOfIndexedPlayer(int index)
    {
        return allPlayers[index].Score;
    }

    public void SetNextReturningPlayerID(int returningID)
    {
        if (returningID == 0)
        {
            returningPlayerID = 1;
        }
        else
        {
            returningPlayerID = 0;
        }
    }

    public bool IsFirstPlayerTurn()
    {
        return returningPlayerID == firstPlayerID;
    }

    public void EndRound()
    {
        if (isEndOfGame())
        {
            endGame();
        }
        else
        {
            Instantiate(ballPrefab, new Vector2(0, 0), Quaternion.identity);
        }
    }

    private bool isEndOfGame()
    {
        bool isEnd = false;
        for (int i = 0; i < allPlayers.Length; i++)
        {
            if (allPlayers[i].Score == endScore)
            {
                isEnd = true;
            }
        }
        return isEnd;
    }

    private void endGame()
    {
        SceneManager.LoadScene("GameEndScene");
    }

    public bool IsPlayerVictorious()
    {
        return returningPlayerID != firstPlayerID;
    }
}
