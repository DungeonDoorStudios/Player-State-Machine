using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanAttackState : PlayerState
{
    public PlayerCanAttackState(Player _player, string _animationBooleanName) : base(_player, _animationBooleanName)
    {
    }

    public override void Update()
    {
        base.Update();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            player.ChangeState(player.AttackState);

            // Do not run any code in the state that called this after
            throw new System.Exception("Attacking!");
        }
    }
}
