using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStartBehaviour : MonoBehaviour
{
    private const float MIN_ANGLE = -45f;
    private const float MAX_ANGLE = 45f;
    private Rigidbody2D ballRigidBody;
    [SerializeField]
    private float ballWaitTime = 0.5f;
    [SerializeField]
    private float initialForce = 2f;
    [SerializeField]
    private RoundManager roundManager;

    private void Awake()
    {
        if (roundManager == null)
        {
            roundManager = FindObjectOfType<RoundManager>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ballRigidBody = GetComponent<Rigidbody2D>();
        StartCoroutine(delayStartRoutine(ballWaitTime));
    }

    private void generateRandomStartForce()
    {
        float startAngle = Mathf.Deg2Rad * Random.Range(MIN_ANGLE, MAX_ANGLE);
        Vector2 ballDirection = new Vector2(Mathf.Cos(startAngle), Mathf.Sin(startAngle));
        Vector2 forceToAdd = initialForce * ballDirection;
        if (roundManager.IsFirstPlayerTurn())
        {
            forceToAdd = reverseForce(forceToAdd);
        }
        ballRigidBody.AddForce(forceToAdd);
    }

    private Vector2 reverseForce(Vector2 forceToReverse)
    {
        return new Vector2(forceToReverse.x * -1, forceToReverse.y);
    }

    private IEnumerator delayStartRoutine(float delayTimeInSeconds)
    {
        yield return new WaitForSeconds(delayTimeInSeconds);
        generateRandomStartForce();
    }
}
