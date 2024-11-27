using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerStateMachine stateMachine;
    private Rigidbody2D rb;
    private Animator anim;

    public PlayerIdleState IdleState { get; private set; }
    public PlayerMoveState MoveState { get; private set; }
    public PlayerAttackState AttackState { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        stateMachine = new PlayerStateMachine();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        IdleState = new PlayerIdleState(this, "idle");
        MoveState = new PlayerMoveState(this, "walk");
        AttackState = new PlayerAttackState(this, "attack");

        stateMachine.ChangeState(IdleState);
    }

    // Update is called once per frame
    void Update()
    {
        stateMachine.Update();
    }

    public void ChangeState(PlayerState newState)
    {
        stateMachine.ChangeState(newState);
    }

    public void SetAnimBool(string boolName, bool value)
    {
        anim.SetBool(boolName, value);
    }

    public void SetVelocity(Vector2 velocity)
    {
        rb.velocity = velocity;

        if (velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    public void ReturnToIdle()
    {
        stateMachine.ChangeState(IdleState);
    }
}
