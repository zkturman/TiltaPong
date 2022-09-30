using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStateFactory: MonoBehaviour
{
    [SerializeField]
    private float maxPlayAreaYCoord;
    [SerializeField]
    private float minPlayAreaYCoord;
    [SerializeField]
    private float moveDelayTime = 0.5f;
    private GameObject currentBall;
    private Transform computerPaddleTransform;

    private void Awake()
    {
        
    }

    public AIState ProduceState()
    {
        return new RandomHeightState(computerPaddleTransform);
    }

    private void configureRandomHeightState()
    {

    }
}
