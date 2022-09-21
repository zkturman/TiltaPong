using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerController : MonoBehaviour, PaddleController
{
    [SerializeField]
    private float maxPlayAreaYCoord;
    [SerializeField]
    private float minPlayAreaYCoord;
    [SerializeField]
    private float moveDelayTime = 0.5f;
    public PlayerBehaviour PlayerBehaviour { get; set; }
    private float paddleYExtent;
    private float minYCoord;
    private float maxYCoord;
    private float targetYCoord;
    private bool isUpMovement = false;
    private bool isDownMovement = false;

    private void Awake()
    {
        PlayerBehaviour = GetComponent<PlayerBehaviour>();
        paddleYExtent = GetComponent<Renderer>().bounds.extents.y;
        maxYCoord = transform.position.y + paddleYExtent;
        minYCoord = transform.position.y - paddleYExtent;
    }
    // Start is called before the first frame update
    void Start()
    {
        setTargetLocation();
        setMovementFlags();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsRelativeUpInputReceived())
        {
            HandleRelativeUpInput();
        }
        else if (IsRelativeDownInputReceived())
        {
            HandleRelativeDownInput();
        }
    }

    private void setTargetLocation()
    {
        targetYCoord = Random.Range(minPlayAreaYCoord, maxPlayAreaYCoord);
    }

    private void setMovementFlags()
    {
        float distanceToTarget = (targetYCoord - transform.position.y);

        if (distanceToTarget > 0f)
        {
            isUpMovement = true;
            isDownMovement = false;
        }
        else
        {
            isDownMovement = true;
            isUpMovement = false;
        }
    }

    public bool IsRelativeUpInputReceived()
    {
        return isUpMovement;
    }

    public bool IsRelativeDownInputReceived()
    {
        return isDownMovement;
    }

    public void HandleRelativeUpInput()
    {
        PlayerBehaviour.MovePaddleRelativelyUp();
        if (shouldSetNewTarget())
        {
            setTargetLocation();
            setMovementFlags();
        }

    }

    public void HandleRelativeDownInput()
    {
        PlayerBehaviour.MovePaddleRelativelyDown();
        if (shouldSetNewTarget())
        {
            setTargetLocation();
            setMovementFlags();
        }
    }

    //private IEnumerator delayMovementBySeconds(float secondsToWait)
    //{
    //    return new WaitForSeconds(secondsToWait);
    //}

    private bool shouldSetNewTarget()
    {
        return isApproximatelyAtTarget() || isPastTarget();
    }

    private bool isApproximatelyAtTarget()
    {
        float distanceToTarget = targetYCoord - transform.position.y;
        return Mathf.Approximately(distanceToTarget, 0f);
    }

    private bool isPastTarget()
    {
        float distanceToTarget = targetYCoord - transform.position.y;
        return Mathf.Sign(distanceToTarget) != Mathf.Sign(targetYCoord);
    }
}
