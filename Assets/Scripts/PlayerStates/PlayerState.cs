using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected Player player;
    private string animBoolName;

    public PlayerState(Player _player, string _animBoolName)
    {
        player = _player;
        animBoolName = _animBoolName;
    }

    public virtual void OnEnter()
    {
        player.SetAnimBool(animBoolName, true);
    }

    public virtual void Update()
    {
        Debug.Log("Updating: " + animBoolName);
    }

    public virtual void OnExit()
    {
        player.SetAnimBool(animBoolName, false);
    }
}
