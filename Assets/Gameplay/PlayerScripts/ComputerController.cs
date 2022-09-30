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
    private PlayerInputType currentInput = PlayerInputType.None;
    private AIState currentState;
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
        Debug.Log("Set target to " + targetYCoord + "; Current Y is " + transform.position.y);
    }

    private void setMovementFlags()
    {
        float distanceToTarget = (targetYCoord - transform.position.y);

        if (distanceToTarget > 0f)
        {
            currentInput = PlayerInputType.UpMovement;
        }
        else
        {
            currentInput = PlayerInputType.DownMovement;
        }

    }

    public bool IsRelativeUpInputReceived()
    {
        return currentInput == PlayerInputType.UpMovement;
    }

    public bool IsRelativeDownInputReceived()
    {
        return currentInput == PlayerInputType.DownMovement;
    }

    public void HandleRelativeUpInput()
    {
        PlayerBehaviour.MovePaddleRelativelyUp();
        if (shouldSetNewTarget())
        {
            setTargetLocation();
            StartCoroutine(delayMovementBySeconds(moveDelayTime));
        }
    }

    public void HandleRelativeDownInput()
    {
        PlayerBehaviour.MovePaddleRelativelyDown();
        if (shouldSetNewTarget())
        {
            setTargetLocation();
            StartCoroutine(delayMovementBySeconds(moveDelayTime));
        }
    }

    private IEnumerator delayMovementBySeconds(float secondsToWait)
    {
        currentInput = PlayerInputType.None;
        yield return new WaitForSeconds(secondsToWait);
        setMovementFlags();
    }

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
        bool pastTarget = true;
        float distanceToTarget = targetYCoord - transform.position.y;
        if (currentInput == PlayerInputType.UpMovement)
        {
            pastTarget = distanceToTarget < 0f;
        }
        else if (currentInput == PlayerInputType.DownMovement)
        {
            pastTarget = distanceToTarget > 0f;
        }

        return pastTarget;
    }
}
