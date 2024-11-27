using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    public PlayerState currentState;

    public void Update()
    {
        if (currentState == null) return;

        currentState.Update();
    }

    public void ChangeState(PlayerState newState)
    {
        if (currentState != null)
        {
            currentState.OnExit();
        }

        currentState = newState;

        currentState.OnEnter();
    }
}
