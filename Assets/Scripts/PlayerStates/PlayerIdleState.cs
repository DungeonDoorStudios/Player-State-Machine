using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerCanAttackState
{
    public PlayerIdleState(Player _Player, string _animBoolName) : base(_Player, _animBoolName)
    {
    }

    public override void Update()
    {
        base.Update();

        Vector2 playerMovementInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (playerMovementInput != Vector2.zero)
        {
            player.ChangeState(player.MoveState);
        }
    }
}
