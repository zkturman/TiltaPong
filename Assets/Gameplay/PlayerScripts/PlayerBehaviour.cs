using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private int score = 0;
    [SerializeField]
    private float speed = 5f;
    private Rigidbody2D paddleRigidBody;

    public int ID { get; set; }
    public int Score
    {
        get => score;
    }

    private void Awake()
    {
        paddleRigidBody = GetComponent<Rigidbody2D>();
    }

    public void IncrementScore()
    {
        score++;
    }

    public void MovePaddleRelativelyUp()
    {
        movePaddleInDirection(Vector2.up);
    }

    public void MovePaddleRelativelyDown()
    {
        movePaddleInDirection(Vector2.down);
    }

    private void movePaddleInDirection(Vector2 direction)
    {
        Vector2 moveForce = direction * speed;
        paddleRigidBody.AddForce(moveForce);
    }
}
