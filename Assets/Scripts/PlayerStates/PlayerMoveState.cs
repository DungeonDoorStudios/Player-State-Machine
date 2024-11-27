using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState : PlayerCanAttackState
{
    public PlayerMoveState(Player _player, string _animBoolName) : base(_player, _animBoolName)
    {
    }

    public override void Update()
    {
        base.Update();

        Vector2 movementInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if(movementInput == Vector2.zero)
        {
            player.ChangeState(player.IdleState);
            return;
        }

        player.SetVelocity(movementInput);
    }
}
