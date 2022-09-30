using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHeightState : AIState
{
    private Transform computerPaddle;
    private float targetHeight;
    private float minimumHeight = -3.9f;
    private float maximumHeight = 3.9f;
    public PlayerInputType CurrentInput { get; private set; }

    public RandomHeightState(Transform computerPaddle)
    {
        this.computerPaddle = computerPaddle;
        CurrentInput = PlayerInputType.None;
    }

    public void SetRandomHeightRange(float minimumHeight, float maximumHeight)
    {
        this.minimumHeight = minimumHeight;
        this.maximumHeight = maximumHeight;
    }

    private void generateTargetLocation()
    {

    }

    public void UpdateCurrentInput()
    {
        if (targetHeight > getCurrentHeight())
        {
            CurrentInput = PlayerInputType.UpMovement;
        }
        else if (targetHeight > getCurrentHeight())
        {
            CurrentInput = PlayerInputType.DownMovement;
        }
    }

    private float getCurrentHeight()
    {
        return computerPaddle.position.y;
    }

    public bool IsFinished()
    {
        bool atTarget = isApproximatelyAtTarget();
        bool pastTarget = isPastTarget();
        return atTarget || pastTarget;
    }

    private bool isApproximatelyAtTarget()
    {
        float distanceToTarget = targetHeight - computerPaddle.position.y;
        return Mathf.Approximately(distanceToTarget, 0f);
    }

    private bool isPastTarget()
    {
        bool pastTarget = true;
        float distanceToTarget = targetHeight - computerPaddle.position.y;
        if (CurrentInput == PlayerInputType.UpMovement)
        {
            pastTarget = distanceToTarget < 0f;
        }
        else if (CurrentInput == PlayerInputType.DownMovement)
        {
            pastTarget = distanceToTarget > 0f;
        }
        return pastTarget;
    }
}
