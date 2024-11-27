using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackState : PlayerState
{
    public PlayerAttackState(Player _player, string animBoolName) : base(_player, animBoolName)
    {
    }

    public override void OnEnter()
    {
        base.OnEnter();

        player.SetVelocity(Vector2.zero);
    }
}
