using UnityEngine;

public class BallCollisionBehaviour : MonoBehaviour
{
    [SerializeField]
    private RoundManager roundManager;

    private void Awake()
    {
        if (roundManager == null)
        {
            roundManager = FindObjectOfType<RoundManager>();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "GoalZone")
        {
            collision.gameObject.GetComponent<GoalZoneBehaviour>().ScorePoint();
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Paddle")
        {
            int returningID = collision.gameObject.GetComponent<PlayerBehaviour>().ID;
            roundManager.SetNextReturningPlayerID(returningID);
        }
    }
}
