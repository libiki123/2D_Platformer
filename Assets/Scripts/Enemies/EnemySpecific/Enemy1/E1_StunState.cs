﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_StunState : StunState
{
	private Enemy1 enemy;

	public E1_StunState(Entity entity, FiniteStateMachine stateMachine, string animBoolName, StunState_SO stateData, Enemy1 enemy) : base(entity, stateMachine, animBoolName, stateData)
	{
		this.enemy = enemy;
	}

	public override void DoChecks()
	{
		base.DoChecks();
	}

	public override void Enter()
	{
		base.Enter();
	}

	public override void Exist()
	{
		base.Exist();
	}

	public override void LogicUpdate()
	{
		base.LogicUpdate();

		if (isStunTimeOver)
		{
			if (performCloseRangeAction)
			{
				stateMachine.ChangeState(enemy.meleeAttackState);
			}
			else if (isPlayerInMinAgroRange)
			{
				stateMachine.ChangeState(enemy.chargeState);
			}
			else
			{
				enemy.lookForPlayerState.SetTurnImmediately(true);
				stateMachine.ChangeState(enemy.lookForPlayerState);
			}
		}
	}

	public override void PhysicsUpdate()
	{
		base.PhysicsUpdate();
	}
}