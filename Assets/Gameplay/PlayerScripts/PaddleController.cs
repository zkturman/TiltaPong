using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PaddleController
{
    public bool IsRelativeUpInputReceived();
    public bool IsRelativeDownInputReceived();
    public void HandleRelativeUpInput();
    public void HandleRelativeDownInput();
}
